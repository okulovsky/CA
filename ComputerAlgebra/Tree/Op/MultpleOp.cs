// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace AIRLab.CA.Tree
{   
    /// <summary>
    /// Implementation of DNF and KNF. Usuing in resolution rule as skolem normal form
    /// </summary>
    public class MultipleOp : Node
    {
        public MultipleOp(Type type, Func<Expression, Expression, Expression> generator,
                    string symbol, params INode[] childs) : base(childs)
        {
            this._generator = generator;
            this._symbol = symbol;
            Type = type;
        }

        private readonly Func<Expression, Expression, Expression> _generator;
        private readonly string _symbol;

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof(IList));
            var expr = Children[0].BuildExpression();
            for (var i = 1; i < Children.Length; i++ )
            {
                expr = Expression.Lambda(Expression.Convert(
                        _generator(
                            expr,
                            Expression.Invoke(Children[i].BuildExpression(), arguments)
                        ), Type), arguments);
            }
            return expr;
        }

        public override string ToString()
        {
            return string.Join(_symbol, Children.Select(z => z.ToString()));
        }
    }

    public static partial class Logic
    {
        public class MultipleAnd : MultipleOp, INode<bool>
        {
            public MultipleAnd(params INode[] childs)
                : base(typeof(bool), Expression.AndAlso, " Λ ", childs)
            { }
        }

        public class MultipleOr : MultipleOp, INode<bool>
        {
            public MultipleOr(params INode[] childs)
                : base(typeof(bool), Expression.OrElse, " V ", childs)
            { }
        }
    }
}
