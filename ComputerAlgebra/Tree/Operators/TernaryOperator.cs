// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Collections;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators
{
    public class TernaryOperator : Node
    {
        public TernaryOperator(Type type, INode child1, INode child2, INode child3) 
            : base(child1, child2, child3)
        {
            Type = type;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof(IList));
            return
                Expression.Lambda(
                    Expression.Convert(
                        Expression.IfThenElse(Expression.Invoke(Children[0].BuildExpression(), arguments),
                            Expression.Invoke(Children[1].BuildExpression(), arguments),
                            Expression.Invoke(Children[2].BuildExpression(), arguments)), Type),
                    arguments);
        }
    }
    public class TernaryOperator<T> : TernaryOperator, INode<T>
    {
        public TernaryOperator(INode child1, INode child2, INode child3)
            : base(typeof(T), child1, child2, child3)
        { }
    }
}