// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree.Nodes
{
    /// <summary>
    /// Implementation of functions in first-order logic. Contstants are functions without children.
    /// </summary>
    public class FunctionNode : TermNode
    {
        public FunctionNode(string name, params INode[] childs)
             :base(name, childs)
        { }

        public override Expression BuildExpression()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Children.Length == 0 ? Name : Name + "(" + string.Join(",", Children.Select(z => z.ToString())) + ")";
        }
    }
}
