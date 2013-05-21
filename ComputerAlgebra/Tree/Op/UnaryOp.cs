// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using System.Collections;
using System.Reflection;

namespace AIRLab.CA.Tree
{
    public class UnaryOp : Node
    {
        public UnaryOp(Type type, INode child, Func<Expression, Expression> generator, string symbol)
            : base (child)
        {
            Type = type;
            this._symbol = symbol;
            this._generator = generator;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof(IList));
            return Expression.Lambda (Expression.Convert(
                _generator(
                    Expression.Invoke(Children[0].BuildExpression(), arguments)
                ), Type), arguments);
        }

        private readonly Func<Expression, Expression> _generator;
        readonly string _symbol;
        public override string ToString()
        {
            return "(" + _symbol + Children[0] + ")";
        }
    }

    public class UnaryFunction : UnaryOp
    {       
        public UnaryFunction(Type type, INode child, MethodInfo method, string symbol)
            : base(type, child,  z=>Expression.Call(null,method,z),symbol)
        {}
    }
   
    public partial class Arithmetic
    {
        public class Negate  : UnaryOp
        {
            public Negate(Type type, INode child)
                : base(type, child, Expression.Negate, "-")
            { }
        }

        public class Negate<T> : Negate, INode<T>
        {
            public Negate(INode child)
                : base(typeof(T), child)
            { }
        }

        public class Sin : UnaryFunction, INode<double>
        {
            public Sin(INode child)
                : base(typeof(double), child, typeof(Math).GetMethod("Sin"), "\\sin")
            { }
        }

        public class Cos : UnaryFunction, INode<double>
        {
            public Cos(INode child)
                : base(typeof(double), child, typeof(Math).GetMethod("Cos"), "\\cos")
            { }
        }

        public class Tan : UnaryFunction, INode<double>
        {
            public Tan(INode child)
                : base(typeof(double), child, typeof(Math).GetMethod("Tan"), "\\tan")
            { }
        }

        public class Ln : UnaryFunction, INode<double>
        {
            public Ln(INode child)
                : base(typeof(double), child, typeof(Math).GetMethod("Log", new Type[] {typeof(double)}), "\\ln")
            { }
        }
    }

    public static partial class Logic
    {
        public class Not : UnaryOp, INode<bool>
        {
            public Not(INode child)
                : base(typeof(bool), child, Expression.Not, "not")
            { }
        }
    }
}