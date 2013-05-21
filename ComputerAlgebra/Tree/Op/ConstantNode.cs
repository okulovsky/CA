using System;
using System.Collections;
using System.Linq.Expressions;

namespace AIRLab.CA
{
    public class Constant : Node
    {
        protected readonly object _data;

        protected Constant(Type type, object data) : base(0)
        {
            _data = data;
            Type = type;
        }

        public override Expression BuildExpression()
        {
            return
                Expression.Lambda (
                   Expression.Constant(_data, Type),
                Expression.Parameter(typeof (IList)));
        }
   
        
        public override string ToString()
        {
            return _data.ToString();
        }

        

        public static Constant<double> Double(double arg) { return new Constant<double>(arg); }
        public static Constant<int> Int(int arg) { return new Constant<int>(arg); }
        public static Constant<bool> Bool(bool arg) { return new Constant<bool>(arg); }

    }

    public class Constant<T> : Constant, INode<T>
    {
        public Constant(T data) : base(typeof(T),data) {}
        public T Value { get { return (T)base._data; } }
   
    }
}