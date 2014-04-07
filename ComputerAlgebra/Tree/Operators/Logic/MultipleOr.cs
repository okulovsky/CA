// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Logic
{
    /// <summary>
    /// Logical disjunction
    /// </summary>
    public class MultipleOr : MultipleOperator, INode<bool>
    {
        public MultipleOr(params INode[] childs)
            : base(typeof(bool), Expression.OrElse, " ∨ ", childs)
        { }
    }
}