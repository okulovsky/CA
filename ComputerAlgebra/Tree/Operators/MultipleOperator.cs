// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Op
{   
    /// <summary>
    /// Implementation of DNF and KNF. Usuing in resolution rule as skolem normal form
    /// </summary>
    public class MultipleOperator : Node
    {
        public MultipleOperator(Type type, Func<Expression, Expression, Expression> generator,
                    string symbol, params INode[] childs) : base(childs)
        {
            _generator = generator;
            _symbol = symbol;
            Type = type;
        }

        private readonly Func<Expression, Expression, Expression> _generator;
        private readonly string _symbol;

        public override Expression BuildExpression()
        {
            var arguments = System.Linq.Expressions.Expression.Parameter(typeof(IList));
            var expr = Children[0].BuildExpression();
            for (var i = 1; i < Children.Length; i++ )
            {
                Expression = System.Linq.Expressions.Expression.Lambda(System.Linq.Expressions.Expression.Convert(
                        _generator(expr,
                            System.Linq.Expressions.Expression.Invoke(Children[i].BuildExpression(), arguments)
                        ), Type), arguments);
            }
            return expr;
        }

        public override string ToString()
        {
            return string.Join(_symbol, Children.Select(z => z.ToString()));
        }

        public LambdaExpression Expression { get; set; }
    }
}
