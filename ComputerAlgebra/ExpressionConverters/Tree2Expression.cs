// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Exceptions;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators;
using AIRLab.CA.Tree.Operators.Arithmetic;

namespace AIRLab.CA.ExpressionConverters
{
    public class Tree2Expression
    {
        public static Expression Parse(INode node)
        {
            try
            {
                return GetTree(node);
            } catch(ParseException e)
            {
                throw new ParseException(string.Format("Failed to parse tree {0} into a expression", node), e);
            }
        }

        private static Expression GetTree(INode node)
        {
            var binaryOperator = node as BinaryOperator;
            if (binaryOperator != null)
            {
                var operand = binaryOperator;
                if(operand is Addition)
                    return Expression.Add(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Minus)
                    return Expression.Subtract(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is ScalarProduct)
                    return Expression.Multiply(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Divide)
                    return Expression.Divide(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Pow)
                    return Expression.Power(GetTree(operand.Children[0]), GetTree(operand.Children[1]));                
            }

            var @operator = node as UnaryOperator;
            if (@operator != null)
            {
                var operand = @operator;
                if (operand is Negate)
                    return Expression.Negate(GetTree(operand.Children[0]));
                if (operand is Sin)
                    return Expression.Call(typeof(Math).GetMethod("Sin"), GetTree(operand.Children[0]));
                if (operand is Cos)
                    return Expression.Call(typeof(Math).GetMethod("Cos"), GetTree(operand.Children[0]));
                if (operand is Tan)
                    return Expression.Call(typeof(Math).GetMethod("Tan"), GetTree(operand.Children[0]));                
                if (operand is Ln)
                    return Expression.Call(typeof(Math).GetMethod("Log", new [] { typeof(double) }), GetTree(operand.Children[0])); 
            }

            var variableNode = node as VariableNode;
            if (variableNode != null)
            {
                var var = variableNode;
                return Expression.Parameter(var.Type, var.ToString());
            }


            var @const = node as Constant;
            if (@const == null) 
                throw new ParseException(string.Format("Unexpected argument '{0}'", node));

            var _const = @const;
            return Expression.Constant(Double.Parse(_const.ToString()), _const.Type);
        }
    }
}
