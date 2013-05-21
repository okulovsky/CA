// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using AIRLab.CA.Tree;

namespace AIRLab.CA.Rules
{

    public class ModInput
    {
        public INode[] Roots { get; set; }
    }

    public class NodeDecorator<T>
        where T: INode
    {
        public T Node { get; private set; }
        public INode InitialParent { get; private set; }
        public int InitialIndex { get; private set; }
        public ModInput Instance;
        public NodeDecorator(ModInput instance, T node)
        {
            this.Instance = instance;
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
