// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;
using System.Linq;

namespace AIRLab.CA.Tree.Rules
{
    public class SelectClauseNode : ISelectClauseNode
    {
        public int Letter { get; private set; }
        public LetterRecursionType Recursive { get; private set; }
        public IList<ISelectClauseNode> Children { get; private set; }
        public ISelectClauseNode Parent { get; set; }
        private SelectClauseNode(int letter, LetterRecursionType recursion, IEnumerable<ISelectClauseNode> children)
        {
            Letter = letter;
            Recursive = recursion;
            Children = children != null ? children.ToList() : new List<ISelectClauseNode>();

            foreach (var c in Children)
            {
                c.Parent = this;
            }

            Parent = null;
        }

        public SelectClauseNode(int letter, LetterRecursionType recursion)
            : this(letter,recursion,null)
        {}

        public ISelectClauseNode this[params ISelectClauseNode[] args]
        {
            get
            {
                return new SelectClauseNode(Letter, Recursive, args);
            }
        }

        public IEnumerable<ISelectClauseNode> GetList()
        {
            yield return this;
            foreach (var n in Children.SelectMany(c => c.GetList()))
            {
                yield return n;
            }
        }
    }
}
