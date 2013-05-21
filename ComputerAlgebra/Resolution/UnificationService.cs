// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree;
using AIRLab.CA.Tools;

namespace AIRLab.CA.Resolution
{
    /// <summary>
    /// Service for operation of unification. Unification rule it's a element of dictionary, where key is "Original node" and value is "Replaced node" or "Node after unification"
    /// </summary>
    public class UnificationService
    {
        /// <summary>
        /// Unification with passed rules
        /// </summary>
        /// <param name="node"></param>
        /// <param name="unificationRules"></param>
        public static void Unificate(INode node, Dictionary<VariableNode, ITermNode> unificationRules)
        {
            if (unificationRules.Count == 0)
                return;
            foreach (var child in node.Children)
            {
                if (child is VariableNode && unificationRules.ContainsKey((VariableNode)child))
                {
                    node.ReplaceChildren(child, unificationRules[(VariableNode)child]);
                }
                else
                {
                    Unificate(child, unificationRules);
                }
            }
        }
        /// <summary>
        /// Unificate passed nodes, if it possible. Otherwise return false
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public static bool Unificate(INode node1, INode node2)
        {
            var unificationRules = GetUnificationRules(node1, node2);
            if (unificationRules == null || unificationRules.Count == 0)
                return false;
            Unificate(node1, unificationRules);
            Unificate(node2, unificationRules);
            return true;
        }

        /// <summary>
        /// Checks, that passed nodes can be unificated
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public static bool CanUnificate(SkolemPredicateNode node1, SkolemPredicateNode node2)
        {
            // The predicate name is unique
            if (!node1.Name.Equals(node2.Name))
                return false;
            return GetUnificationRules(node1, node2) != null;
        }

        /// <summary>
        /// Get unification rules for passed nodes
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public static Dictionary<VariableNode, ITermNode> GetUnificationRules(INode node1, INode node2)
        {
            if (node1.Children.Count() != node2.Children.Count())
                return null;
            var tempNode1 = (INode)node1.Clone();
            var tempNode2 = (INode)node2.Clone();
            var rules = new Dictionary<VariableNode, ITermNode>(new TermNodeComparer());
            for (var i = 0; i < tempNode1.Children.Length; i++)
            {
                var child1 = tempNode1.Children[i];
                var child2 = tempNode2.Children[i];
                if (IsSame(child1, child2, true))
                    continue;
                if (child1 is VariableNode)
                    rules.Add((VariableNode)child1, (ITermNode)child2);
                else if(child2 is VariableNode)
                    rules.Add((VariableNode)child2, (ITermNode)child1);
                else if (IsSame(child1, child2, false))
                {
                    var temp = GetUnificationRules(child1, child2);
                    if (temp == null)
                        return null;
                    rules.AddRange(temp);
                }
                else
                {
                    return null;
                }
                Unificate(tempNode1, rules);
                Unificate(tempNode2, rules);
            }
            return rules;
        }
        /// <summary>
        /// Checks the external equity of nodes (the equality of names and arity)
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <param name="withChildren">Checks for all the children recursively</param>
        /// <returns></returns>
        public static bool IsSame(INode node1, INode node2, bool withChildren)
        {
            var term1 = node1 as ITermNode;
            var term2 = node2 as ITermNode;
            if (term1 == null || term2 == null)
            {
                return false;
            }
            if(term1.Children.Length != term2.Children.Length)
            {
                return false;
            }
            return term1.Name.Equals(term2.Name) && (!withChildren || 
                term1.Children.Aggregate(term1.Name.Equals(term2.Name), (current1, childA) => term2.Children.Aggregate(current1, (current, childB) => current && IsSame(childA, childB, true))));
        }

        private class TermNodeComparer : IEqualityComparer<ITermNode>
        {
            public bool Equals(ITermNode x, ITermNode y)
            {
                return IsSame(x, y, true);
            }

            public int GetHashCode(ITermNode obj)
            {
                return obj.Name.GetHashCode() + obj.Children.Sum(child => ((ITermNode) child).Name.GetHashCode());
            }
        }
    }
}
