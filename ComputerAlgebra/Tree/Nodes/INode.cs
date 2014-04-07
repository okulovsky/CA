// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree.Nodes
{
    public interface INode : ICloneable
    {
        IChildrenCollection Children { get; }
        INode Parent { get; set; }
        Type Type { get; }
        Expression BuildExpression();
        void MakeRoot();
    }

    public interface INode<T> : INode { }
}
