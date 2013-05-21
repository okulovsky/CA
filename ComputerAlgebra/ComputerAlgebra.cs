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

namespace AIRLab.CA
{
    public static class ComputerAlgebra
    {
        public static Expression Simplify(Expression e)
        {
            return Tree2Expression.Parse(Simplify(Expressions2Tree.Parse(e)));
        }

        public static INode Simplify(INode tree)
        {
            return Simplifier.Simplify(tree, GetSimplificationRules());
        }

        public static Expression Differentiate(Expression e, int index=0, String variable="")
        {
            var node = Expressions2Tree.Parse(e);
            return Tree2Expression.Parse(Differentiate(node, index, variable));
        }

        private static List<Rule> GetSimplificationRules()
        {
            var simplificationRules = AlgebraicRules.Get()
                                 .Where(r => r.Tags.Contains(StdTags.Simplification))
                                 .ToList();
            simplificationRules.AddRange(LogicRules.Get().Where(r => r.Tags.Contains(StdTags.Simplification)));
            return simplificationRules;
        }

        public static INode Differentiate(INode node, int index = 0, String variable = "")
        {
            var varIndex = index;
            var rules = GetSimplificationRules();
            rules.AddRange(DifferentiationRules.Get());
            if (!variable.Equals("") && NodeElementNames.GetVariableNodeNames().IndexOf(variable) != -1)
            {
                varIndex = NodeElementNames.GetVariableNodeNames().IndexOf(variable);
            }
            return Simplifier.Simplify(new Differentiation.Dif<double>(node, VariableNode.Make<double>(varIndex, "variable")), rules);            
        }        
    }
}
