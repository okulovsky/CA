using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    /// <summary>
    /// Scalar product
    /// </summary>
    public class ScalarProduct : BinaryOperator
    {
        public ScalarProduct(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Multiply, "∙", false)
        { }
    }

    /// <summary>
    /// Scalar product
    /// </summary>
    public class ScalarProduct<T> : ScalarProduct, INode<T>
    {
        public ScalarProduct(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }
}