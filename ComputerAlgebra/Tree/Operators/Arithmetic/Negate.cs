using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Negate<T> : Negate, INode<T>
    {
        public Negate(INode child)
            : base(typeof(T), child)
        { }
    }

    public class Negate  : UnaryOperator
    {
        public Negate(Type type, INode child)
            : base(type, child, Expression.Negate, "-")
        { }
    }
}