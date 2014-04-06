// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public class SelectOutput : ISelectOutput
    {
        public INode[] SelectedNodes { get; private set; }
        public INode[] Roots { get; private set; }
        public SelectOutput(INode[] selectedNodes, INode[] roots)
        {
            SelectedNodes = selectedNodes;
            Roots = roots;
        }
    }
}
