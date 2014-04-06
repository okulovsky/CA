// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Exceptions;
using AIRLab.CA.Groups;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Logic;
using AIRLab.CA.Tree.Rules;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA.ExpressionConverters
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
            }
            catch(ParseException exp)
            {
                throw new ParseException(string.Format("Failed to parse expression {0} into a logic tree", expr), exp);
            }
        }

        private static INode GetTree(Expression body)
        {
            var expression = body as BinaryExpression;
            if (expression == null) 
                return new MultipleOr(GetOperands(body, false).ToArray());

            var operand = expression;
            if (!operand.NodeType.Equals(ExpressionType.Or))
                throw new ParseException(string.Format("Unexepted expression '{0}'", expression));

            var operands = GetOperands(operand.Left, false).ToList();
            operands.AddRange(GetOperands(operand.Right, false));

            return new MultipleOr(operands.ToArray());
        }

        private static IEnumerable<INode> GetOperands(Expression expr, bool negate)
        {
            while (true)
            {
                var expression = expr as BinaryExpression;
                if (expression != null)
                {
                    var be = expression;
                    foreach (var op in GetOperands(be.Left, false))
                    {
                        yield return op;
                    }
                    expr = be.Right;
                    negate = false;
                    continue;
                }
                if (expr.NodeType.Equals(ExpressionType.Not))
                {
                    expr = ((UnaryExpression) expr).Operand;
                    negate = true;
                    continue;
                }
                if (expr.NodeType.Equals(ExpressionType.Call))
                {
                    var method = (MethodCallExpression) expr;
                    var operands = new List<INode>();
                    var argument = (NewArrayExpression) method.Arguments[0];
                    if (argument == null)
                    {
                        throw new ParseException("Parse error");
                    }
                    if (method.Type == typeof (BooleanGroup))
                    {
                        foreach (var arg in argument.Expressions)
                        {
                            operands.AddRange(GetOperands(arg, false));
                        }
                        yield return new SkolemPredicateNode(method.Method.Name, negate, operands.ToArray());
                    }
                    else
                    {
                        foreach (var arg in argument.Expressions)
                        {
                            if (arg.NodeType.Equals(ExpressionType.Parameter))
                            {
                                operands.Add(VariableNode.Make<bool>(NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression) arg).Name), ((ParameterExpression) arg).Name));
                            }
                            else if (arg.NodeType.Equals(ExpressionType.Call))
                            {
                                operands.AddRange(GetOperands(arg, false));
                            }
                            else if (arg.NodeType.Equals(ExpressionType.Constant))
                            {
                                operands.Add(new FunctionNode(NodeElementNames.GetConstantNames().ElementAt((int) ((ConstantExpression) arg).Value)));
                            }
                        }
                        yield return new FunctionNode(method.Method.Name, operands.ToArray());
                    }
                }
                else if (expr.NodeType.Equals(ExpressionType.Parameter))
                {
                    yield return VariableNode.Make<bool>(NodeElementNames.GetVariableNodeNames().IndexOf(((ParameterExpression) expr).Name), ((ParameterExpression) expr).Name);
                }
                else if (expr.NodeType.Equals(ExpressionType.Constant))
                {
                    yield return new FunctionNode(NodeElementNames.GetConstantNames().ElementAt((int) ((ConstantExpression) expr).Value));
                }
                break;
            }
        }
    }
}
