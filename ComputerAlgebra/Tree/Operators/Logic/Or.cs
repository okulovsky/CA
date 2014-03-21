using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Logic
{
    public class Or : BinaryOperator, INode<bool>
    {
        public Or(INode child1, INode child2)
            : base(typeof(bool), child1, child2, Expression.OrElse, "or", false)
        { }
    }
}