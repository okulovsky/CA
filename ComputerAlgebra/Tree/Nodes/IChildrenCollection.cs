// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;

namespace AIRLab.CA.Tree.Nodes
{
    public interface IChildrenCollection : IEnumerable<INode>
    {
        INode this[int index] { get; set; }
        int Length { get; }

        void ReleaseChild(int index);
        INode[] ChildrenArray { get; set; }
    }
}