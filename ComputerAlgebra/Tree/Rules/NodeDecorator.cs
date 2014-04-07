// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public class NodeDecorator<T> : INodeDecorator<T>
        where T: INode
    {
        public T Node { get; private set; }
        public INode InitialParent { get; private set; }
        public int InitialIndex { get; private set; }
        public IModInput Instance { get; private set; }
        public NodeDecorator(IModInput instance, T node)
        {
            Instance = instance;
            Node = node;
            InitialParent = (node).Parent;
            if (InitialParent!=null)
                InitialIndex = InitialParent.IndexOfChild(node);
        }
        public void Replace(INode newNode)
        {
            //replace the current parents node by new node
            if (InitialParent != null)
                InitialParent.Children[InitialIndex] = newNode;
            else
            {
                newNode.MakeRoot();
                for (var i = 0; i < Instance.Roots.Length; i++)
                    if (Instance.Roots[i] == (INode)Node)
                        Instance.Roots[i] = newNode;
            }
            
        }
    }
}