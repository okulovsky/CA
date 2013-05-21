// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Tools;

namespace AIRLab.CA.Tree
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
            children = new ChildrenCollection(this, childCount);
        }

        internal Node parent;
        internal ChildrenCollection children;
        public IChildrenCollection Children { get { return children; } }
        public INode Parent { get { return parent; } }
        public Type Type { get; protected set; }
        public abstract Expression BuildExpression();

        public object Clone()
        {
            var clone = (Node)MemberwiseClone();
            if (Children != null)
            {
                clone.children = new ChildrenCollection(clone, children.Length);
                for (var i = 0; i < clone.Children.Length; ++i)
                {
                    clone.Children[i] = (Node)(Children[i].Clone());
                }
            }
            clone.parent = null;
            return clone;
        }

        public void MakeRoot()
        {
            if (parent == null) return;
            var ind = parent.Children.IndexOf(this);
            parent.Children[ind] = null;
        }
    }
   
    public class ChildrenCollection : IChildrenCollection
    {
        private readonly Node _owner;
        private readonly Node[] _childrenArray;
        public ChildrenCollection(Node owner, int length)
        {
            _owner = owner;
            _childrenArray = new Node[length];
        }

        private void AddChild(Node child, int index)
        {
            if (child == null) return;
            if (child.Parent != null)
                child.parent.children.ReleaseChild(Array.IndexOf(child.parent.children._childrenArray, child));
            _childrenArray[index] = child;
            child.parent = _owner;
        }

        private void ReleaseChild(int index)
        {
            if (_childrenArray[index] == null) return;
            if (_childrenArray[index].parent == _owner)
                _childrenArray[index].parent = null;
            _childrenArray[index] = null;
        }

        public INode this[int index]
        {
            get
            {
                return _childrenArray[index];
            }
            set
            {
                var n = (Node)value;
                ReleaseChild(index);
                AddChild(n, index);
            }
        }

        public int Length
        {
            get { return _childrenArray.Length; }
        }

        public IEnumerator<INode> GetEnumerator()
        {
            return _childrenArray.Cast<INode>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _childrenArray.GetEnumerator();
        }
   }
}
