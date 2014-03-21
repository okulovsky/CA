using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Comparison
{
    public class LessThan: BinaryOperator, INode<bool>
    {
        public LessThan(INode child1, INode child2)
            : base(typeof(bool), child1, child2, Expression.LessThan, "<", false)
        { }
    }
}