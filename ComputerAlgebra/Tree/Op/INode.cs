using System;
using System.Collections;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;


namespace Bulldozer
{
    public interface INode<T> : INode { }

    public interface INode: ICloneable
    {
        INode[] Children { get; set; }
        INode Parent { get; set; }
        Type Type { get; }
        Expression BuildExpression();
    }

    public static class INodeExtensions
    {

        public static int IndexOfChild(this INode node, INode child)
        {
            for (int i = 0; i < node.Children.Length; i++)
                if (node.Children[i] == child) return i;
            return -1;
        }

        public static bool IsRoot(this INode node)
        {
            return node.Parent == null;
        }

        public static bool HasChildren(this INode node)
        {
            return node.Children != null && node.Children.Length != 0;
        }

        public static int GetOperationCount(this INode node)
        {
            return node.Children==null?1:1 + node.Children.Select(z => z.GetOperationCount()).Sum();
        }

        public static void ReplaceChild(this INode parent, INode oldChild, INode newChild)
        {
            int ind = parent.IndexOfChild(oldChild);
            parent.Children[ind] = newChild;
        }

        public static Func<IList,T> ComplileDelegate<T>(this INode parent)
        {
            var arguments = Expression.Parameter(typeof (IList));            
            return Expression.Lambda<Func<IList, T>>(Expression.Invoke(parent.BuildExpression(), arguments), arguments).Compile();
        }

        public static IEnumerable<INode> GetSubTree(this INode node)
        {
            var stopParent = node.Parent;
            while (true)
            {
                yield return node;
                if (node.HasChildren())
                {
                    node = node.Children[0];
                    continue;
                }
                while (true)
                {
                    var parent = node.Parent;
                    if (parent == stopParent) yield break;
                    var index = parent.IndexOfChild(node);
                    if (index<parent.Children.Length-1)
                    {
                        node = parent.Children[index + 1];
                        break;
                    }
                    node = parent;
                }
            }
        }
    }
}