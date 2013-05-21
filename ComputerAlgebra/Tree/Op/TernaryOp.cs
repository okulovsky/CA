// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree
{
    public class TernaryOp : Node
    {
        public TernaryOp(Type type, INode child1, INode child2, INode child3) 
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

    public class TernaryOp<T> : TernaryOp, INode<T>
    {
        public TernaryOp(INode child1, INode child2, INode child3)
            : base(typeof(T), child1, child2, child3)
        { }
    }
}