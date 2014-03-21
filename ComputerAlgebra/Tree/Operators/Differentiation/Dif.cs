using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Differentiation
{
    /// <summary>
    /// Differential
    /// </summary>
    public class Dif : BinaryOperator
    {
        public Dif(Type type, INode child1, VariableNode child2)
            : base(type, child1, child2, Expression.Add, "dif", false)
        { }
    }

    /// <summary>
    /// Differential
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Dif<T> : Dif, INode<T>
    {
        public Dif(INode child1, VariableNode child2)
            : base(typeof(T), child1, child2)
        { }
    }
}