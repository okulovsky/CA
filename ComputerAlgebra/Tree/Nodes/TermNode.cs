// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

namespace AIRLab.CA.Tree
{
    public abstract class TermNode : Node, ITermNode
    {
        public string Name { get; private set; }

        protected TermNode(string name, params INode[] childs)
             :base(childs)
        {
            Name = name;
        }
    }
}
