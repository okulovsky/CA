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
    public class UnaryOperator : Node
    {
        public UnaryOperator(Type type, INode child, Func<Expression, Expression> generator, string symbol)
            : base(child)
        {
            Type = type;
            _symbol = symbol;
            _generator = generator;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof (IList));
            return Expression.Lambda(Expression.Convert(
                _generator(
                    Expression.Invoke(Children[0].BuildExpression(), arguments)
                    ), Type), arguments);
        }

        private readonly Func<Expression, Expression> _generator;
        private readonly string _symbol;

        public override string ToString()
        {
            return string.Format(_symbol, Children[0]);
        }
    }
}
