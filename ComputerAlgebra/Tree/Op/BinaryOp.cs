// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using System.Collections;

namespace AIRLab.CA.Tree
{
    public class BinaryOp : Node
    {
        public BinaryOp(Type type, INode child1, INode child2, Func<Expression, Expression, Expression> generator,
                        string symbol, bool prenex) : base(child1, child2)
        {
            Type = type;
            this._generator = generator;
            this._symbol = symbol;
            this._prenex = prenex;
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof (IList));
            return Expression.Lambda(Expression.Convert(
                _generator(
                    Expression.Invoke(Children[0].BuildExpression(), arguments),
                    Expression.Invoke(Children[1].BuildExpression(), arguments)
                    ), Type), arguments);
        }

        private readonly Func<Expression, Expression, Expression> _generator;
        private readonly string _symbol;
        private readonly bool _prenex;

        public override string ToString()
        {
            return _prenex
                       ? _symbol + "(" + Children[0] + "," + Children[1] + ")"
                       : "(" + Children[0] + " " + _symbol + " " + Children[1] + ")";
        }
    }

    public partial class Arithmetic
    {
        public class Plus : BinaryOp
        {
            public Plus(Type type, INode child1, INode child2)
                : base(type, child1, child2, Expression.Add, "+", false)
            { }
        }

        public class Plus<T> : Plus, INode<T>
        {
            public Plus(INode child1, INode child2)
                : base(typeof(T), child1, child2)
            { }
        }

        public class Minus : BinaryOp
        {
            public Minus(Type type, INode child1, INode child2)
                : base(type, child1, child2, Expression.Subtract, "-", false)
            { }
        }

        public class Minus<T> : Minus, INode<T>
        {
            public Minus(INode child1, INode child2)
                : base(typeof(T), child1, child2)
            { }
        }

        public class Product : BinaryOp
        {
            public Product(Type type, INode child1, INode child2)
                : base(type, child1, child2, Expression.Multiply, "∙", false)
            { }
        }

        public class Product<T> : Product, INode<T>
        {
            public Product(INode child1, INode child2)
                : base(typeof(T), child1, child2)
            { }
        }

        public class Divide : BinaryOp
        {
            public Divide(Type type, INode child1, INode child2)
                : base(type, child1, child2, Expression.Divide, "", false)
            { }

            public override string ToString()
            {
                return "(" + Children[0] + ")/(" + Children[1] + ")";
            }
        }

        public class Divide<T> : Divide, INode<T>
        {
            public Divide(INode child1, INode child2)
                : base(typeof(T), child1, child2)
            { }
        }

        public class Pow : BinaryOp
        {
            public Pow(Type type, INode child1, INode child2)
                : base(type, child1, child2, Expression.Power, "^", false)
            { }
        }

        public class Pow<T> : Pow, INode<T>
        {
            public Pow(INode child1, INode child2)
                : base(typeof(T), child1, child2)
            { }
        }
    }
    public static partial class Differentiation
    {
        public class Dif : BinaryOp
        {
            public Dif(Type type, INode child1, VariableNode child2)
                : base(type, child1, child2, Expression.Add, "dif", false)
            { }
        }

        public class Dif<T> : Dif, INode<T>
        {
            public Dif(INode child1, VariableNode child2)
                : base(typeof(T), child1, child2)
            { }
        }
    }
    public static partial class Logic
    {
        public class And : BinaryOp, INode<bool>
        {
            public And(INode child1, INode child2)
                : base(typeof(bool), child1, child2, Expression.AndAlso, "and", false)
            { }
        }

        public class Or : BinaryOp, INode<bool>
        {
            public Or(INode child1, INode child2)
                : base(typeof(bool), child1, child2, Expression.OrElse, "or", false)
            { }
        }
    }

    public static partial class Comparison
    {
        public class LessThan: BinaryOp, INode<bool>
        {
            public LessThan(INode child1, INode child2)
                : base(typeof(bool), child1, child2, Expression.LessThan, "<", false)
            { }
        }

        public class Equal : BinaryOp, INode<bool>
        {
            public Equal(INode child1, INode child2)
                : base(typeof(bool), child1, child2, Expression.Equal, "=", false)
            { }
        }
    }

}