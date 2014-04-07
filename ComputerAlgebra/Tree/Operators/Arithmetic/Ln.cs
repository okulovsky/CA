// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Ln : UnaryFunction, INode<double>
    {
        public Ln(INode child)
            : base(typeof(double), child, typeof(Math).GetMethod("Log", new [] { typeof(double) }), "ln({0})")
        { }
    }
}
