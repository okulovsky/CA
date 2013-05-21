// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Linq.Expressions;
using System;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{
    public class Expressions2Tree
    {
        public static INode Parse(Expression e)
        {
            try
            {
                var body = e is LambdaExpression ? ((LambdaExpression)e).Body : e;
                return GetTree(body);
            } catch(ParseException exp)
            {
                throw new ParseException(string.Format("Failed to parse expression {0} into a tree", e), exp);
            }
        }

        private static INode GetTree(Expression e)
        {
            if(e is BinaryExpression)
            {
                var operand = (BinaryExpression)e;
                switch (e.NodeType)
                {
                        // +
                    case System.Linq.Expressions.ExpressionType.Add:                        
                        return new Arithmetic.Plus<double>(GetTree(operand.Left), GetTree(operand.Right));   
                        // -
                    case System.Linq.Expressions.ExpressionType.Subtract:
                        return new Arithmetic.Minus<double>(GetTree(operand.Left), GetTree(operand.Right));       
                        // *        
                    case System.Linq.Expressions.ExpressionType.Multiply:
                        return new Arithmetic.Product<double>(GetTree(operand.Left), GetTree(operand.Right));
                        // /
                    case System.Linq.Expressions.ExpressionType.Divide:
                        return new Arithmetic.Divide<double>(GetTree(operand.Left), GetTree(operand.Right));   
                        // ^
                    case System.Linq.Expressions.ExpressionType.Power:
                        return new Arithmetic.Pow<double>(GetTree(operand.Left), GetTree(operand.Right));
                }
            }
            if (e.NodeType.Equals(System.Linq.Expressions.ExpressionType.Negate))
            {
                return new Arithmetic.Negate<double>(GetTree(((UnaryExpression)e).Operand));
            }
            if (e.NodeType.Equals(System.Linq.Expressions.ExpressionType.Call))
            {
                var method = (MethodCallExpression)e;
                if(method.Method.Equals(typeof(Math).GetMethod("Pow")))
                    return new Arithmetic.Pow<double>(GetTree(method.Arguments[0]), GetTree(method.Arguments[1]));
                if (method.Method.Equals(typeof(Math).GetMethod("Cos")))
                    return new Arithmetic.Cos(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Sin")))
                    return new Arithmetic.Sin(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Tan")))
                    return new Arithmetic.Tan(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Log", new[] { typeof(double) })))
                    return new Arithmetic.Ln(GetTree(method.Arguments[0]));   

            }
            if (e.NodeType.Equals(System.Linq.Expressions.ExpressionType.Parameter))
            {
                return VariableNode.Make<double>(NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression)e).Name), ((ParameterExpression)e).Name);
            }
            if (e.NodeType.Equals(System.Linq.Expressions.ExpressionType.Constant))
            {
                return Constant.Double((double)(((ConstantExpression)e).Value));
            }
            throw new ParseException(string.Format("Unexpected expression '{0}'", e));
        }
    }
}
