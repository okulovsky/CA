using System.Collections.Generic;

namespace AIRLab.CA.Tree.Nodes
{
    public interface IChildrenCollection : IEnumerable<INode>
    {
        INode this[int index] { get; set; }
        int Length { get; }
    }
}