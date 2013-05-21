// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{
    class Tree2Expression
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
            if (node is BinaryOp)
            {
                var operand = (BinaryOp)node;
                if(operand is Arithmetic.Plus)
                    return Expression.Add(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Arithmetic.Minus)
                    return Expression.Subtract(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Arithmetic.Product)
                    return Expression.Multiply(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Arithmetic.Divide)
                    return Expression.Divide(GetTree(operand.Children[0]), GetTree(operand.Children[1]));
                if(operand is Arithmetic.Pow)
                    return Expression.Power(GetTree(operand.Children[0]), GetTree(operand.Children[1]));                
            }
            if (node is UnaryOp)
            {
                var operand = (UnaryOp)node;
                if (operand is Arithmetic.Negate)
                    return Expression.Negate(GetTree(operand.Children[0]));
                if (operand is Arithmetic.Sin)
                    return Expression.Call(typeof(Math).GetMethod("Sin"), GetTree(operand.Children[0]));
                if (operand is Arithmetic.Cos)
                    return Expression.Call(typeof(Math).GetMethod("Cos"), GetTree(operand.Children[0]));
                if (operand is Arithmetic.Tan)
                    return Expression.Call(typeof(Math).GetMethod("Tan"), GetTree(operand.Children[0]));                
                if (operand is Arithmetic.Ln)
                    return Expression.Call(typeof(Math).GetMethod("Log", new Type[] { typeof(double) }), GetTree(operand.Children[0])); 
            }
            if (node is VariableNode)
            {
                var var = (VariableNode)node;
                return Expression.Parameter(var.Type, var.ToString());
            }
            if (node is Constant)
            {
                var _const = (Constant)node;
                return Expression.Constant(Double.Parse(_const.ToString()), _const.Type);
            }
            throw new ParseException(string.Format("Unexpected argument '{0}'", node));
        }
    }
}
