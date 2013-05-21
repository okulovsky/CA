// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Rules
{
    public abstract class WhereOutput
    {
        public SelectOutput SelectResult;
        
        SelectOutput MakeSafeCloning()
        {
            var path = new List<int>();
            var newRoots = SelectResult.Roots.Select(z => z.Clone<INode>()).ToArray();
            var result = new INode[SelectResult.SelectedNodes.Length];
            INode newRoot = null;
            for (var i = 0; i < SelectResult.SelectedNodes.Length; i++)
            {
                var node = SelectResult.SelectedNodes[i];
                path.Clear();
                while (true)
                {
                    var rootIndex = Array.IndexOf(SelectResult.Roots, node);
                    if (rootIndex != -1)
                    {
                        newRoot = newRoots[rootIndex];
                        break;
                
                    }
                    var p = node.Parent;
                    if (p == null)
                        break;
                    path.Add(p.IndexOfChild(node));
                    node = p;
                }

                
                if (newRoot==null)
                    throw new Exception("Something strange: a root of selected nodes is not listed in root array.");

                path.Reverse();
                foreach (var cNum in path)
                    newRoot = newRoot.Children[cNum];

                result[i] = newRoot;
            }
            return new SelectOutput(result, newRoots);
        }

        protected abstract ModInput MakeSafeRuleInstance(INode[] closedNodes);

        public ModInput MakeSafe()
        {
            var cl = MakeSafeCloning();
            var result=MakeSafeRuleInstance(cl.SelectedNodes);
            result.Roots = cl.Roots;
            return result;
        }


    }
}
