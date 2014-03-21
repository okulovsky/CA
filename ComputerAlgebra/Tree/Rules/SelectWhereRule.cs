namespace AIRLab.CA.Tree.Rules
{
    public class SelectWhereRule
    {
        public SelectRule SelectRule;
        public SelectWhereRule(SelectRule selectRule)
        {
            SelectRule = selectRule;
        }
    }
}