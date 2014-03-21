using System;
using System.Linq.Expressions;

namespace Bulldozer
{
    public abstract class Node: INode
    {
        public INode[] Children { get; set; }
        public INode Parent { get; set; }
        public Type Type { get; protected set; }
        public abstract Expression  BuildExpression();

        public object Clone()
        {
            var clone = (INode) MemberwiseClone();
            if (Children != null)
            {
                clone.Children = new INode[Children.Length];
                for (var i = 0; i < clone.Children.Length; ++i)
                {
                    clone.Children[i] = (INode)Children[i].Clone();
                    clone.Children[i].Parent = clone;
                }
            }
            return clone;
        }

        



    }
}