// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{
    
    public class String2Tree
    {        
        private static ArrayList _tokens;
        public static INode Parse(string formula)
        {
            formula = formula.Replace("*", "∙");
            var parser = new RPNParser();
            _tokens = parser.GetPostFixNotation(formula,
                                    Type.GetType("System.Int64"), true);
            if(_tokens.Count == 0)
            {
                throw new ParseException(string.Format("Failed to get postfix notation of string '{0}'", formula));
            }
            _tokens.Reverse();
            try
            {
                return GetTree();
            } catch(ParseException e)
            {
                throw new ParseException(string.Format("Failed to parse string '{0}' into a correct tree", formula), e);
            }
        }

        private static INode GetTree()
        {
            try
            {
                if (_tokens.Count == 0)
                {
                    throw new ParseException("Not enough operands");
                }
                if (_tokens[0] is IOperator)
                {
                    var oper = (Operator) _tokens[0];
                    _tokens.RemoveAt(0);
                    INode temp;
                    switch (oper.Value)
                    {
                        case "+":
                            temp = new Arithmetic.Plus<double>(GetTree(), GetTree());
                            temp.SwitchCoupleOfChildren();
                            return temp;
                        case "-":
                            temp = new Arithmetic.Minus<double>(GetTree(), GetTree());
                            temp.SwitchCoupleOfChildren();
                            return temp;
                        case "∙":
                            temp = new Arithmetic.Product<double>(GetTree(), GetTree());
                            temp.SwitchCoupleOfChildren();
                            return temp;
                        case "/":
                            temp = new Arithmetic.Divide<double>(GetTree(), GetTree());
                            temp.SwitchCoupleOfChildren();
                            return temp;
                        case "^":
                            temp = new Arithmetic.Pow<double>(GetTree(), GetTree());
                            temp.SwitchCoupleOfChildren();
                            return temp;
                    }
                }
                if (_tokens[0] is IOperand)
                {
                    var operand = (Operand) _tokens[0];
                    _tokens.RemoveAt(0);
                    if (NodeElementNames.GetVariableNodeNames().IndexOf(operand.Name) != -1)
                    {
                        return VariableNode.Make<double>(NodeElementNames.GetVariableNodeNames().IndexOf(operand.Name),
                                                         operand.Name);
                    }
                    return Constant.Double(Double.Parse(operand.Name));
                }
            } catch(FormatException exp)
            {
                throw new ParseException("Error in parsing. Perhaps you've forgotten the multiplication sign '*'", exp);
            }
            throw new ParseException(string.Format("Unexpected symbol '{0}'", _tokens[0]));
        }

    }
}
