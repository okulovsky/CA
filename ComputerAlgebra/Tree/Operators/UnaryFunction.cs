using System;
using System.Linq.Expressions;
using System.Reflection;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators
{
    public class UnaryFunction : UnaryOperator
    {       
        public UnaryFunction(Type type, INode child, MethodInfo method, string symbol)
            : base(type, child,  z=>Expression.Call(null,method,z),symbol)
        {}
    }
}