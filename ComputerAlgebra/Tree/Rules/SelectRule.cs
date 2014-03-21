using AIRLab.CA.Rules;

namespace AIRLab.CA.Tree.Rules
{
    public partial class SelectRule
    {
        public ComplexSelector Selector;
        public NewRule NewRule;
        public SelectRule(NewRule newRule, ComplexSelector selector)
        {
            Selector = selector;
            NewRule = newRule;
        }
    }
}