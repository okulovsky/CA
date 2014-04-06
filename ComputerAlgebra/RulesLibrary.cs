// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Regression;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Rules;
using AIRLab.CA.Tree.RulesCollection;

namespace AIRLab.CA
{
    public static class RulesLibrary
    {
        /// <summary>
        /// Apply each rule from collection to passed node, while it possible
        /// </summary>
        /// <param name="node"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        public static INode ApplyRules(INode node, IRule[] rules)
        {
            var current = node;
            string firstRep;

            do
            {
                firstRep = current.ToString();
                foreach (var r in rules)
                {
                    var instances = r.SelectWhere(current);
                    var whereOutputs = instances as WhereOutput[] ?? instances.ToArray();
                    if (instances == null || !whereOutputs.Any()) 
                        continue;

                    foreach (var roots in whereOutputs.Select(r.Apply).Where(roots => roots != null && roots.Any() && roots[0] != null))
                    {
                        current = roots[0];
                        break;
                    }
                }
            } 
            while (firstRep != current.ToString());

            return current;
        }

        /// <summary>
        /// Get a list of algebraic and logic simplification rules
        /// </summary>
        /// <returns></returns>
        public static IRule[] GetSimplificationRules()
        {
            var simplificationRules = AlgebraicRules.Get()
                                 .Where(r => r.Tags.Contains(StdTags.Simplification))
                                 .ToList();
            simplificationRules.AddRange(LogicRules.Get().Where(r => r.Tags.Contains(StdTags.Simplification)));
            return simplificationRules.ToArray();
        }

        /// <summary>
        /// Get a list of simple differentiation rules
        /// </summary>
        /// <returns></returns>
        public static IList<IRule> GetDifferentiationRules()
        {
            return DifferentiationRules.Get().ToList();
        }

        /// <summary>
        /// You can run regression algorithm by applying these rules 
        /// </summary>
        /// <param name="inSample">Experimental data</param>
        /// <param name="exactResult">Experimental result</param>
        /// <returns></returns>
        public static IList<IRule> GetRegeressionRule(IList<double[]> inSample, IList<double> exactResult)
        {
            return RegressionRules.Get(inSample, exactResult).ToList();
        }

        /// <summary>
        /// Rule from resolution technique, used for deciding the satisfiability of a propositional formula, in first-order-logic 
        /// </summary>
        /// <seealso cref="ComputerAlgebra.Resolve"/>
        /// <returns></returns>
        public static IRule GetResolutionRule()
        {
            return ResolutionRule.Get();
        }
    }
}
