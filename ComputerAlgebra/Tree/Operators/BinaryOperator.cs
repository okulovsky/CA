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
    public class BinaryOperator : Node
    {
        private readonly Func<Expression, Expression, Expression> _generator;
        private readonly string _format;

        public BinaryOperator(Type type, INode child1, INode child2, Func<Expression, Expression, Expression> generator,
            string format) : base(child1, child2)
        {
            Type = type;
            _generator = generator;
            _format = format;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof(IList));
            return Expression.Lambda(Expression.Convert(
                _generator(
                    Expression.Invoke(Children[0].BuildExpression(), arguments),
                    Expression.Invoke(Children[1].BuildExpression(), arguments)
                    ), Type), arguments);
        }

        public override string ToString()
        {
            return string.Format(_format, Children[0], Children[1]);
        }
    }
}