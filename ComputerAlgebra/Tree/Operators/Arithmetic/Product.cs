using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Product : BinaryOperator
    {
        public Product(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Multiply, "∙", false)
        { }
    }
    public class Product<T> : Product, INode<T>
    {
        public Product(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }
}