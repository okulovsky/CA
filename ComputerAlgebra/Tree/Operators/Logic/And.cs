using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Logic
{
    public class And : BinaryOperator, INode<bool>
    {
        public And(INode child1, INode child2)
            : base(typeof(bool), child1, child2, Expression.AndAlso, "and", false)
        { }
    }
}