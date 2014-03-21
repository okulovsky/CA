using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Plus<T> : Plus, INode<T>
    {
        public Plus(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }

    public class Plus : BinaryOperator
    {
        public Plus(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Add, "+", false)
        { }
    }
}