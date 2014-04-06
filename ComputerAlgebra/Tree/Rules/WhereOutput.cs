// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA.Tree.Rules
{
    public abstract class WhereOutput : IWhereOutput
    {
        public ISelectOutput SelectResult { get; set; }

        private ISelectOutput MakeSafeCloning()
        {
            var path = new List<int>();
            var newRoots = SelectResult.Roots.Select(z => z.Clone<INode>()).ToArray();
            var result = new INode[SelectResult.SelectedNodes.Count()];
            INode newRoot = null;
            for (var i = 0; i < SelectResult.SelectedNodes.Count(); i++)
            { 
                var node = SelectResult.SelectedNodes[i];
                newRoot = node.CloneNode(path, newRoot, newRoots, SelectResult);
                result[i] = newRoot;
            }
            return new SelectOutput(result, newRoots);
        }

        protected abstract IModInput MakeSafeRuleInstance(IList<INode> closedNodes);

        public IModInput MakeSafe()
        {
            var cl = MakeSafeCloning();
            var result = MakeSafeRuleInstance(cl.SelectedNodes);
            result.Roots = cl.Roots;
            return result;
        }
    }
}
