// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Exceptions;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Arithmetic;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA.ExpressionConverters
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
            var expression = e as BinaryExpression;
            if(expression != null)
            {
                var operand = expression;
                switch (expression.NodeType)
                {
                        // +
                    case ExpressionType.Add:
                        return new Addition<double>(GetTree(operand.Left), GetTree(operand.Right));   
                        // -
                    case ExpressionType.Subtract:
                        return new Minus<double>(GetTree(operand.Left), GetTree(operand.Right));       
                        // *        
                    case ExpressionType.Multiply:
                        return new ScalarProduct<double>(GetTree(operand.Left), GetTree(operand.Right));
                        // /
                    case ExpressionType.Divide:
                        return new Divide<double>(GetTree(operand.Left), GetTree(operand.Right));   
                        // ^
                    case ExpressionType.Power:
                        return new Pow<double>(GetTree(operand.Left), GetTree(operand.Right));
                }
            }

            if (e.NodeType.Equals(ExpressionType.Negate))
            {
                return new Negate<double>(GetTree(((UnaryExpression)e).Operand));
            }

            if (e.NodeType.Equals(ExpressionType.Call))
            {
                var method = (MethodCallExpression)e;
                if(method.Method.Equals(typeof(Math).GetMethod("Pow")))
                    return new Pow<double>(GetTree(method.Arguments[0]), GetTree(method.Arguments[1]));
                if (method.Method.Equals(typeof(Math).GetMethod("Cos")))
                    return new Cos(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Sin")))
                    return new Sin(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Tan")))
                    return new Tan(GetTree(method.Arguments[0]));
                if (method.Method.Equals(typeof(Math).GetMethod("Log", new[] { typeof(double) })))
                    return new Ln(GetTree(method.Arguments[0]));   

            }

            if (e.NodeType.Equals(ExpressionType.Parameter))
            {
                return VariableNode.Make<double>(NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression)e).Name), ((ParameterExpression)e).Name);
            }

            if (e.NodeType.Equals(ExpressionType.Constant))
            {
                return new Constant<double>((double)(((ConstantExpression)e).Value));
            }

            throw new ParseException(string.Format("Unexpected expression '{0}'", e));
        }
    }
}
