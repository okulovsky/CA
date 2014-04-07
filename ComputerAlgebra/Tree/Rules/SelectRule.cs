// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

namespace AIRLab.CA.Tree.Rules
{
    public class SelectRule : ISelectRule
    {
        public IComplexSelector Selector { get; private set; }
        public INewRule NewRule { get; private set; }

        public SelectRule(INewRule newRule, IComplexSelector selector)
        {
            Selector = selector;
            NewRule = newRule;
        }
    }
}
