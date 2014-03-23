using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Addition : BinaryOperator
    {
        public Addition(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Add, "+", false)
        { }
    }

    public class Addition<T> : Addition, INode<T>
    {
        public Addition(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }
}