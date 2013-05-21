// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Rules
{

    partial class BasicSelector
    {
        
        #region Selector instructions preparation

    
        public class LetterInstruction
        {
            /// <summary>
            /// Letter index for this instruction
            /// </summary>
            public int LetterIndex;
            /// <summary>
            /// Letter index for parent
            /// </summary>
            public int ParentIndex;
            /// <summary>
            /// True, if letter is root. Else false
            /// </summary>
            public bool IsRoot;
            /// <summary>
            /// Letter number in parent childs array
            /// </summary>
            public int ChildNumberInArray;
            /// <summary>
            /// Letter indexes of left brothers
            /// </summary>
            public int[] LeftBrotherIndexes;
            /// <summary>
            /// Recursion type of this letter
            /// </summary>
            public LetterRecursionType Recursive;
            /// <summary>
            /// Arity of the operation (not for leaves)
            /// </summary>
            public int? Arity;

            public IEnumerator<INode> Enumerator;
            public bool BreakThisBranch;
            public void Reset()
            {
                BreakThisBranch = false;
                Enumerator = null;
            }

            static IEnumerable<INode> CreateEnumerable(params INode[] data)
            {
                return data;
            }

            static IEnumerable<INode> FilterArity(int arity, IEnumerable<INode> bs)
            {
                foreach (var e in bs)
                {
                    if (
                        (arity == 0 && !e.HasChildren()) ||
                        (arity > 0 && e.HasChildren() && e.Children.Length == arity)
                        )
                    {
                        yield return e;
                    }
                }
            }

            IEnumerable<INode> FilterBrothers(INode[] current, IEnumerable<INode> bs)
            {
                if (LeftBrotherIndexes != null && LeftBrotherIndexes.Length != 0)
                {
                    return bs.Except(LeftBrotherIndexes.Select(z => current[z]));
                }
                return bs;
            }

            void CreateEnumerator(INode[] current, INode root)
            {
                var enumerable=CreateEnumerable();

                switch (Recursive)
                {
                    case LetterRecursionType.No:
                        if (IsRoot)
                            enumerable = CreateEnumerable(root);
                        else
                        {
                            var n = current[ParentIndex];
                            if (n.Children != null || n.Children.Length > ChildNumberInArray)
                                enumerable = CreateEnumerable(n.Children[ChildNumberInArray]);
                        }
                        break;
                        
                    case LetterRecursionType.Subtree:
                        var rt = IsRoot ? root : current[ParentIndex];
                        var collection = rt.GetSubTree();
                        collection = IsRoot ? collection : collection.Skip(1);
                        collection = collection.ToArray();
                        enumerable= collection;
                        break;
                            
                    case LetterRecursionType.Children:
                        if (IsRoot)
                            enumerable = CreateEnumerable(root);
                        else if (current[ParentIndex].HasChildren())
                                enumerable = current[ParentIndex].Children;
                            
                        break;
                        
                }

                if (Arity != null) enumerable = FilterArity(Arity.Value, enumerable);
                if (Recursive != LetterRecursionType.No) enumerable = FilterBrothers(current,enumerable);
                Enumerator = enumerable.GetEnumerator();

            }


            public bool ApplyInstruction(INode[] current, INode root)
            {
                if (Enumerator == null) CreateEnumerator(current, root);
                var breackBranch = !Enumerator.MoveNext();
                if (!breackBranch)
                    current[LetterIndex] = Enumerator.Current;
                return breackBranch;
            }
        }



        public class SelectIntruction
        {
            public int ArrayLength;
            public List<LetterInstruction> Letters = new List<LetterInstruction>();
        }

        public static SelectIntruction PrepareInstructions(SelectClauseNode parseRoot)
        {
            var res = new SelectIntruction {ArrayLength = parseRoot.GetList().Select(z => z.Letter).Max() + 1};
            foreach (var e in parseRoot.GetList())
            {
                var ins = new LetterInstruction {LetterIndex = e.Letter, IsRoot = e.Parent == null};
                if (!ins.IsRoot)
                {
                   ins.ParentIndex = e.Parent.Letter;
                   ins.ChildNumberInArray = e.Parent.Children.IndexOf(e);
                   ins.LeftBrotherIndexes = e.Parent.Children.Take(ins.ChildNumberInArray).Select(z => z.Letter).ToArray();
                }
                else
                {
                    ins.LeftBrotherIndexes = new int[] { };
                }

                if (e.Children.Count != 0)
                {
                    if (e.Children.Count != 0)
                    {
                        var sub = Math.Sign(e.Children.Where(z => z.Recursive == LetterRecursionType.Subtree).Count());
                        var child = Math.Sign(e.Children.Where(z => z.Recursive == LetterRecursionType.Children).Count());
                        var clear = Math.Sign(e.Children.Where(z => z.Recursive == LetterRecursionType.No).Count());
                        if (sub + child + clear > 1) throw new Exception("Error in rule: letter " + (char)('A' + e.Letter) + " must have only one type of childs (for example A(?B,.C) is not acceptable)");
                        if (clear != 0)
                            ins.Arity = e.Children.Count;
                    }
                    
                }

                ins.Recursive = e.Recursive;
                res.Letters.Add(ins);
            }
            return res;
        }
    
    

        #endregion

        readonly SelectIntruction _instruction;



        public BasicSelector(SelectClauseNode clause)
        {
            _instruction = PrepareInstructions(clause);
        }

       
        
        public IEnumerable<INode[]> Select(INode root)
        {
            var result = new INode[_instruction.ArrayLength];
            var currentInstruction=0;
            _instruction.Letters[0].Reset();

            while(true)
            {
                if (currentInstruction==-1) break;

                if (_instruction.Letters[currentInstruction].ApplyInstruction(result,root))
                {
                    currentInstruction--;
                    continue;
                }

                currentInstruction++;
                if (currentInstruction == _instruction.Letters.Count)
                {
                    yield return result.ToArray();
                    currentInstruction--;
                    continue;
                }
                _instruction.Letters[currentInstruction].Reset();
                continue;
            }
        }
    }
}
