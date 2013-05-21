// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using AIRLab.CA.Tree;

namespace AIRLab.CA.Rules
{
    public class SelectOutput
    {
        public readonly INode[] SelectedNodes;
        public readonly INode[] Roots;
        public SelectOutput(INode[] selectedNodes, INode[] roots)
        {
            SelectedNodes = selectedNodes;
            Roots = roots;
        }
    }
}
