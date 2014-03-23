// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree.Nodes
{
    public interface INode : ICloneable
    {
        IChildrenCollection Children { get; }
        INode Parent { get; }
        Type Type { get; }
        Expression BuildExpression();
        void MakeRoot();
    }

    public interface INode<T> : INode { }
}
