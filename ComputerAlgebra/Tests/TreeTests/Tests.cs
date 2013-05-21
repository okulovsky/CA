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
using AIRLab.CA.RulesCollection;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;


namespace AIRLab.CA.Tests
{
    public class Tests
    {
        protected delegate double del();
        protected delegate double del1(double p);
        protected delegate double del2(double p1, double p2);

        public static INode SimplifyStringExpression(string formula)
        {
            return Simplifier.Simplify(String2Tree.Parse(formula), GetAlgebraicSimplificationRules());
        }

        public static INode SimplifyBinaryExpression(Expression e)
        {
            return Simplifier.Simplify(Expressions2Tree.Parse(e), GetAlgebraicSimplificationRules());
        }

        public static INode SimplifyDifferentation(Expression e, String variable)
        {
            if (NodeElementNames.GetVariableNodeNames().IndexOf(variable) == -1)
                return null;
            var rules = GetAlgebraicSimplificationRules();
            rules.AddRange(DifferentiationRules.Get());
            return Simplifier.Simplify(new Differentiation.Dif<double>(Expressions2Tree.Parse(e), VariableNode.Make<double>(NodeElementNames.GetVariableNodeNames().IndexOf(variable), "variable")), rules);
        }

        public static INode SimplifyLogicTree(INode root)
        {
            return Simplifier.Simplify(root, GetLogicSimplificationRules());
        }

        private static List<Rule> GetAlgebraicSimplificationRules()
        {
            return AlgebraicRules.Get().Where(r => r.Tags.Contains(StdTags.SafeResection)).ToList();
        }

        private static List<Rule> GetLogicSimplificationRules()
        {
            return LogicRules.Get().Where(r => r.Tags.Contains(StdTags.SafeResection)).ToList();
        }
    }
}
