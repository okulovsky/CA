using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Op;

namespace AIRLab.CA.Tree.Operators.Logic
{
    public class MultipleOr : MultipleOperator, INode<bool>
    {
        public MultipleOr(params INode[] childs)
            : base(typeof(bool), System.Linq.Expressions.Expression.OrElse, " V ", childs)
        { }
    }
}