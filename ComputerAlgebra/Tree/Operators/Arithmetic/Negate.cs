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
    public class Negate : UnaryOperator
    {
        public Negate(Type type, INode child)
            : base(type, child, Expression.Negate, "-({0})")
        { }
    }

    public class Negate<T> : Negate, INode<T>
    {
        public Negate(INode child)
            : base(typeof(T), child)
        { }
    }
}