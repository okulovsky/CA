// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{

    public class Expressions2LogicTree : LogicExpressions
    {
        public static INode Parse(Expression expr)
        {
            try
            {
                if (!(expr is LambdaExpression || expr is BinaryExpression))
                {
                    throw new ParseException(string.Format("Incorrect expression type"));
                }
                var body = expr is LambdaExpression ? ((LambdaExpression)expr).Body : expr;
                return GetTree(body);
            } catch(ParseException exp)
            {
                throw new ParseException(string.Format("Failed to parse expression {0} into a logic tree", expr), exp);
            }
        }

        private static INode GetTree(Expression body)
        {
            if (body is BinaryExpression)
            {
                var operand = (BinaryExpression) body;
                if(operand.NodeType.Equals(System.Linq.Expressions.ExpressionType.Or))
                {
                    var operands = GetOperands(operand.Left, false).ToList();
                    operands.AddRange(GetOperands(operand.Right, false));
                    return new Logic.MultipleOr(operands.ToArray());
                }
            }
            else
            {
                return new Logic.MultipleOr(GetOperands(body, false).ToArray());
            }
            throw new ParseException(string.Format("Unexepted expression '{0}'", body));
        }

        private static IEnumerable<INode> GetOperands(Expression expr, bool negate)
        {
            if (expr is BinaryExpression)
            {
                var be = (BinaryExpression) expr;
                foreach (var op in GetOperands(be.Left, false))
                {
                    yield return op;
                }
                foreach (var op in GetOperands(be.Right, false))
                {
                    yield return op;
                }
            }
            else if (expr.NodeType.Equals(System.Linq.Expressions.ExpressionType.Not))
            {
                foreach (var op in GetOperands(((UnaryExpression)expr).Operand, true))
                {
                    yield return op;
                }
            }
            else if (expr.NodeType.Equals(System.Linq.Expressions.ExpressionType.Call))
            {
                var method = (MethodCallExpression)expr;
                var operands = new List<INode>();
                var argument = (NewArrayExpression)method.Arguments[0];
                if (argument == null)
                {
                    throw new ParseException("Parse error");
                }
                if (method.Type == typeof (CABoolean))
                {
                    foreach (var arg in argument.Expressions)
                    {
                        operands.AddRange(GetOperands(arg, false));
                    }
                    yield return new SkolemPredicateNode(method.Method.Name, negate, operands.ToArray());
                }
                else
                {
                    foreach (Expression arg in argument.Expressions)
                    {
                        if (arg.NodeType.Equals(System.Linq.Expressions.ExpressionType.Parameter))
                        {
                            operands.Add(
                                VariableNode.Make<bool>(
                                    NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression) arg).Name),
                                    ((ParameterExpression) arg).Name));
                        }
                        else if(arg.NodeType.Equals(System.Linq.Expressions.ExpressionType.Call))
                        {
                            operands.AddRange(GetOperands(arg, false));
                        } 
                        else if(arg.NodeType.Equals(System.Linq.Expressions.ExpressionType.Constant))
                        {
                            operands.Add(new FunctionNode(NodeElementNames.GetConstantNames().ElementAt((int)((ConstantExpression)arg).Value)));
                        }
                    }
                    yield return new FunctionNode(method.Method.Name, operands.ToArray());
                }
            }
            else if (expr.NodeType.Equals(System.Linq.Expressions.ExpressionType.Parameter))
            {
                yield return VariableNode.Make<bool>(NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression)expr).Name), ((ParameterExpression)expr).Name);
            }
            else if (expr.NodeType.Equals(System.Linq.Expressions.ExpressionType.Constant))
            {
                yield return new FunctionNode(NodeElementNames.GetConstantNames().ElementAt((int)((ConstantExpression)expr).Value));
            }
        } 
    }
}
