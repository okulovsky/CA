// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators
{
    public class BinaryOperator : Node
    {
        public BinaryOperator(Type type, INode child1, INode child2, Func<Expression, Expression, Expression> generator, string symbol, bool isPrefixOperator) 
            : base(child1, child2)
        {
            Type = type;
            _generator = generator;
            _symbol = symbol;
            IsPrefixOperator = isPrefixOperator;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof (IList));
            var invoked1 = Expression.Invoke(Children[0].BuildExpression(), arguments);
            var invoked2 = Expression.Invoke(Children[1].BuildExpression(), arguments);
            var generated = _generator(invoked1, invoked2);
            var converted = Expression.Convert(generated, Type);
            return Expression.Lambda(converted, arguments);
        }

        private readonly Func<Expression, Expression, Expression> _generator;
        private readonly string _symbol;
        
        public override string ToString()
        {
            var format = IsPrefixOperator ? "{0}({1},{2})" : "({1} {0} {2})";
            return string.Format(format, _symbol, Children[0], Children[1]);
        }

        public bool IsPrefixOperator { get; private set; }
    }
}