// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree
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
