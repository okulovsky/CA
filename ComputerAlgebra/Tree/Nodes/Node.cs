// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA.Tree.Nodes
{
    public abstract class Node : INode
    {
        protected Node(params INode[] children)
            : this(children.Length)
        {
            for (var i = 0; i < children.Length; i++)
                Children[i] = children[i];
        }

        protected Node(int childCount)
        {
            Children = new ChildrenCollection(this, childCount);
        }

        public IChildrenCollection Children { get; private set; }
        public INode Parent { get; set; }
        public Type Type { get; protected set; }
        public abstract Expression BuildExpression();

        public object Clone()
        {
            var clone = (Node)MemberwiseClone();
            if (Children != null)
            {
                clone.Children = new ChildrenCollection(clone, Children.Length);
                for (var i = 0; i < clone.Children.Length; ++i)
                {
                    clone.Children[i] = (INode)(Children[i].Clone());
                }
            }
            clone.Parent = null;
            return clone;
        }

        public void MakeRoot()
        {
            if (Parent == null) return;
            var ind = Parent.Children.IndexOf(this);
            Parent.Children[ind] = null;
        }

        // public abstract string ToLatex();
    }
}
