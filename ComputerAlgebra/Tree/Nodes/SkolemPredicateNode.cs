// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

namespace AIRLab.CA.Tree
{
    /// <summary>
    /// This is a ordinary predicate, but with indication of negation. 
    /// </summary>
    public class SkolemPredicateNode : PredicateNode
    {
        public static readonly string NegationSymbol = "!"; 
        public bool IsNegate { get; set; }

        public SkolemPredicateNode(string name, bool negation, params INode[] childs) : base(name, childs)
        {
            IsNegate = negation;
        }

        public override string ToString()
        {
            return (IsNegate) ? NegationSymbol + base.ToString() : base.ToString();
        }
    }
}
