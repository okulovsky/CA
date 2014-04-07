// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Comparison
{
    public class Equal : BinaryOperator, INode<bool>
    {
        public Equal(INode child1, INode child2)
            : base(typeof(bool), child1, child2, Expression.Equal, "{0} = {1}")
        { }
    }
}