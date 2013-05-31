// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Rules;
using AIRLab.CA.RulesCollection;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{
    public static class RulesLibrary
    {
        /// <summary>
        /// Apply each rule from collection to passed node, while it possible
        /// </summary>
        /// <param name="node"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        public static INode ApplyRules(INode node, List<Rule> rules)
        {
            var current = node;
            string firstRep;
            do
            {
                firstRep = current.ToString();
                foreach (var r in rules)
                {
                    var instances = r.SelectWhere(current);
                    if (instances == null || instances.Count() == 0) continue;
                    foreach (var ins in instances)
                    {
                        var roots = r.Apply(ins);
                        if (roots == null || roots.Count() == 0 || roots[0] == null) continue;
                        current = roots[0];
                        break;
                    }
                }
            } while (firstRep != current.ToString());
            return current;
        } 
        /// <summary>
        /// Get a list of algebraic and logic simplification rules
        /// </summary>
        /// <returns></returns>
        public static List<Rule> GetSimplificationRules()
        {
            var simplificationRules = AlgebraicRules.Get()
                                 .Where(r => r.Tags.Contains(StdTags.Simplification))
                                 .ToList();
            simplificationRules.AddRange(LogicRules.Get().Where(r => r.Tags.Contains(StdTags.Simplification)));
            return simplificationRules;
        }
        /// <summary>
        /// Get a list of simple differentiation rules
        /// </summary>
        /// <returns></returns>
        public static List<Rule> GetDifferentiationRules()
        {
            return DifferentiationRules.Get().ToList();
        }
        /// <summary>
        /// You can run regression algorithm by applying these rules 
        /// </summary>
        /// <param name="inSample">Experimental data</param>
        /// <param name="exactResult">Experimental result</param>
        /// <returns></returns>
        public static List<Rule> GetRegeressionRule(List<double[]> inSample, List<double> exactResult)
        {
            return RegressionRules.Get(inSample, exactResult).ToList();
        }
        /// <summary>
        /// Rule from resolution technique, used for deciding the satisfiability of a propositional formula, in first-order-logic 
        /// </summary>
        /// <seealso cref="ComputerAlgebra.Resolve"/>
        /// <returns></returns>
        public static Rule GetResolutionRule()
        {
            return ResolutionRule.Get();
        }
    }
}
