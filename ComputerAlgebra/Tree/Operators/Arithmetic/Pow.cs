// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Pow<T> : Pow, INode<T>
    {
        public Pow(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }

    public class Pow : BinaryOperator
    {
        public Pow(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Power, "({0})^({1})")
        { }
    }
}