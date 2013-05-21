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
    public class Constant : Node
    {
        protected readonly object Data;

        protected Constant(Type type, object data) : base(0)
        {
            Data = data;
            Type = type;
        }

        public override Expression BuildExpression()
        {
            return
                Expression.Lambda (
                   Expression.Constant(Data, Type),
                Expression.Parameter(typeof (IList)));
        }
   
        
        public override string ToString()
        {
            return Data.ToString();
        }

        

        public static Constant<double> Double(double arg) { return new Constant<double>(arg); }
        public static Constant<int> Int(int arg) { return new Constant<int>(arg); }
        public static Constant<bool> Bool(bool arg) { return new Constant<bool>(arg); }

    }

    public class Constant<T> : Constant, INode<T>
    {
        public Constant(T data) : base(typeof(T),data) {}
        public T Value { get { return (T)base.Data; } }
   
    }
}