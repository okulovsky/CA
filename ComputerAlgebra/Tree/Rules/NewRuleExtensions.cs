// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

namespace AIRLab.CA.Tree.Rules
{
    public static class NewRuleInterfaceExtensions
    {
        public static ISelectRule Select(this INewRule rule, params ISelectClauseNode[] clauses)
        {
            return new SelectRule(rule, new ComplexSelector(clauses));
        }
    }
}