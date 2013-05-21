// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.RulesCollection;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Resolution
{
    /// <summary>
    /// Service for resolution rule
    /// </summary>
    public static class ResolutionService
    {
        /// <summary>
        /// Apply the resolution rule to passed disjuncts
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns>The list of formulas, which is a the logical consequence of input disjuncts</returns>
        public static IEnumerable<INode> Resolve(INode node1, INode node2)
        {
            var result = new List<INode>();
            var rule = ResolutionRule.Get();
            var instances = rule.SelectWhere(node1, node2);
            foreach (var ins in instances)
            {
                var nodes = rule.Apply(ins).Where(z => z.Children.Length > 0).ToArray();
                result.Add(nodes.Length == 1 ? nodes[0] : new Logic.MultipleOr(nodes));
            }
            return result;
        }
    }
}
