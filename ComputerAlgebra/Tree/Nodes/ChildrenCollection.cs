// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AIRLab.CA.Tree.Nodes
{
    public class ChildrenCollection : IChildrenCollection
    {
        private readonly INode _owner;
        public INode[] ChildrenArray {get; set;}
        public ChildrenCollection(INode owner, int length)
        {
            _owner = owner;
            ChildrenArray = new INode[length];
        }

        private void AddChild(INode child, int index)
        {
            if (child == null) return;
            if (child.Parent != null)
                child.Parent.Children.ReleaseChild(Array.IndexOf(child.Parent.Children.ChildrenArray, child));
            ChildrenArray[index] = child;
            child.Parent = _owner;
        }

        public void ReleaseChild(int index)
        {
            if (ChildrenArray[index] == null) return;
            if (ChildrenArray[index].Parent == _owner)
                ChildrenArray[index].Parent = null;
            ChildrenArray[index] = null;
        }

        public INode this[int index]
        {
            get
            {
                return ChildrenArray[index];
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
            get { return ChildrenArray.Length; }
        }

        public IEnumerator<INode> GetEnumerator()
        {
            return ChildrenArray.Cast<INode>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ChildrenArray.GetEnumerator();
        }
    }
}