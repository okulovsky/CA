// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System;
using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    internal static class NodeInterfaceExtensions
    {
        public static INode CloneNode(this INode node, List<int> path, INode newRoot, INode[] newRoots, ISelectOutput result)
        {
            path.Clear();
            while (true)
            {
                var rootIndex = Array.IndexOf(result.Roots, node);
                if (rootIndex != -1)
                {
                    newRoot = newRoots[rootIndex];
                    break;
                }
                var p = node.Parent;
                if (p == null)
                {
                    break;
                }

                path.Add(p.IndexOfChild(node));
                node = p;
            }
            if (newRoot == null)
            {
                throw new InvalidOperationException("Something strange: a root of selected nodes is not listed in root array.");
            }

            path.Reverse();
            newRoot = path.Aggregate(newRoot, (current, cNum) => current.Children[cNum]);
            return newRoot;
        }
    };
}