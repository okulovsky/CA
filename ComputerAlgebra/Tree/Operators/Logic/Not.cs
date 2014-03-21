using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Logic
{
    public class Not : UnaryOperator, INode<bool>
    {
        public Not(INode child)
            : base(typeof(bool), child, Expression.Not, "not")
        { }
    }
}