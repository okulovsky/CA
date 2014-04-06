// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using System.Reflection;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators
{
    public class UnaryFunction : UnaryOperator
    {
        public UnaryFunction(Type type, INode child, MethodInfo method, string symbol)
            : base(type, child, z => Expression.Call(null, method, z), symbol)
        {
        }
    }
}