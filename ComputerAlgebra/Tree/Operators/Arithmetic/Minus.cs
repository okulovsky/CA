using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Minus<T> : Minus, INode<T>
    {
        public Minus(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }

    public class Minus : BinaryOperator
    {
        public Minus(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Subtract, "-", false)
        { }
    }
}