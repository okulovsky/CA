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
    public class Divide<T> : Divide, INode<T>
    {
        public Divide(INode child1, INode child2)
            : base(typeof(T), child1, child2)
        { }
    }

    public class Divide : BinaryOperator
    {
        public Divide(Type type, INode child1, INode child2)
            : base(type, child1, child2, Expression.Divide, "({0})/({1})")
        { }
    }
}