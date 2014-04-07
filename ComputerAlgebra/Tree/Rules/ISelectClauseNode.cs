// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;

namespace AIRLab.CA.Tree.Rules
{
    public interface ISelectClauseNode
    {
        IEnumerable<ISelectClauseNode> GetList();
        int Letter { get; }
        LetterRecursionType Recursive { get; }
        IList<ISelectClauseNode> Children { get; }
        ISelectClauseNode Parent { get; set; }

        ISelectClauseNode this[params ISelectClauseNode[] args] { get; }
    }
}