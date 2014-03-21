using AIRLab.CA.Rules;

namespace AIRLab.CA.Tree.Rules
{
    public class NewRule
    {
        public string Name;
        public string[] Tags;
        public NewRule(string name, string[] tags)
        {
            Name = name;
            Tags = tags;
        }

        public SelectRule Select(params SelectClauseNode[] clauses)
        {
            return new SelectRule(this,new ComplexSelector(clauses));
        }
    }
}