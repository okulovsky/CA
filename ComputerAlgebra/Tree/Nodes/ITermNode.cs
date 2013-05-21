// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

namespace AIRLab.CA.Tree
{
    /// <summary>
    /// Implementation of Terms in first-order logic.
    /// </summary>
    public interface ITermNode : INode<bool>
    {
        string Name { get; }
    }
}
