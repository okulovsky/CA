// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Differentiation;
using AIRLab.CA.Tree.Operators.Logic;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA
{
    public static class ComputerAlgebra
    {
        /// <summary>
        /// Simplify expression, using simplification rules from <see cref="RulesLibrary"/>
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Expression Simplify(Expression e)
        {
            return Tree2Expression.Parse(Simplify(Expressions2Tree.Parse(e)));
        }

        /// <summary>
        /// Simplify tree, using simplification rules from <see cref="RulesLibrary"/>
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public static INode Simplify(INode tree)
        {
            return RulesLibrary.ApplyRules(tree, RulesLibrary.GetSimplificationRules());
        }

        /// <summary>
        /// Calculate partial differentiation of function, represented as expression
        /// </summary>
        /// <seealso cref="Differentiate(INode,int,string)"/>
        /// <param name="e"></param>
        /// <param name="index"></param>
        /// <param name="variable"></param>
        /// <returns></returns>
        public static Expression Differentiate(Expression e, int index=0, String variable="")
        {
            var node = Expressions2Tree.Parse(e);
            return Tree2Expression.Parse(Differentiate(node, index, variable));
        }

        /// <summary>
        /// Calculate partial differentiation of function, represented as syntax tree
        /// </summary>
        /// <param name="node">Function tree</param>
        /// <param name="index">Index of variable</param>
        /// <param name="variable">Variable symbol</param>
        /// <returns></returns>
        public static INode Differentiate(INode node, int index = 0, String variable = "")
        {
            var varIndex = index;
            var varName = NodeElementNames.GetVariableNodeNames().ElementAt(index);
            var rules = RulesLibrary.GetSimplificationRules();
            rules.AddRange(RulesLibrary.GetDifferentiationRules());
            if (!variable.Equals("") && NodeElementNames.GetVariableNodeNames().IndexOf(variable) != -1)
            {
                varIndex = NodeElementNames.GetVariableNodeNames().IndexOf(variable);
                varName = variable;
            }
            return RulesLibrary.ApplyRules(new Dif<double>(node, VariableNode.Make<double>(varIndex, varName)), rules);            
        }

        /// <summary>
        /// Apply the resolution rule to passed clauses
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns>The list of formulas, which is a the logical consequence of input clauses</returns>
        public static IEnumerable<INode> Resolve(INode node1, INode node2)
        {
            var result = new List<INode>();
            var rule = RulesLibrary.GetResolutionRule();
            var instances = rule.SelectWhere(node1, node2);
            foreach (var ins in instances)
            {
                var nodes = rule.Apply(ins).Where(z => z.Children.Length > 0).ToArray();
                result.Add(nodes.Length == 1 ? nodes[0] : new MultipleOr(nodes));
            }
            return result;
        }
    }
}
