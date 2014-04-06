// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Differentiation
{
    /// <summary>
    /// ordinary differential equation
    /// </summary>
    public class Dif<T> : Dif, INode<T>
    {
        public Dif(INode child1, VariableNode child2)
            : base(typeof(T), child1, child2)
        { }
    }

    /// <summary>
    /// ordinary differential equation
    /// </summary>
    public class Dif : BinaryOperator
    {
        public Dif(Type type, INode child1, VariableNode child2)
            : base(type, child1, child2, Expression.Add, "{0}´({1})")
        { }
    }
}