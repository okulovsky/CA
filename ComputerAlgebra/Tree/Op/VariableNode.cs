using System;
using System.Collections;
using System.Linq.Expressions;

namespace AIRLab.CA
{
    public class VariableNode : Node
    {
        public int Index { get; private set; }
        private readonly string _name;

        public VariableNode(Type type, int index, string name) : base(0)
        {
            Index = index;
            _name = name;
            Type = type;
        }

        public static VariableNode Make<T>(int index, string name)
        {
            return new VariableNode(typeof(T), index, name);
        }

        public override Expression BuildExpression()
        {
            var arguments = Expression.Parameter(typeof (IList));
            return 
                Expression.Lambda (
                    Expression.Block(
                        Expression.Convert(
                            Expression.Call(arguments, typeof (IList).GetMethod("get_Item"),
                                            Expression.Constant(Index)), 
                        Type)), 
                arguments);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}