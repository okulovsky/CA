// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using System.Linq;

namespace AIRLab.CA.Rules
{

        public enum LetterRecursionType
        {
            No,
            Subtree,
            Children
        }

    public class SelectClauseNode
    {
        public int Letter;
        public LetterRecursionType Recursive;
        public List<SelectClauseNode> Children;
        public SelectClauseNode Parent;
        private SelectClauseNode(int letter, LetterRecursionType recursion, IEnumerable<SelectClauseNode> children)
        {
            Letter = letter;
            Recursive = recursion;
            Children = children!=null?children.ToList():new List<SelectClauseNode>();
            foreach (var c in Children) c.Parent = this;
            this.Parent = null;
        }

        public SelectClauseNode(int letter, LetterRecursionType recursion)
            : this(letter,recursion,null)
        {}

        public SelectClauseNode this[params SelectClauseNode[] args]
        {
            get
            {
                return new SelectClauseNode(Letter, Recursive, args);
            }
        }

        public IEnumerable<SelectClauseNode> GetList()
        {
            yield return this;
            foreach (var c in Children)
                foreach (var n in c.GetList())
                    yield return n;
        }
    }
}
