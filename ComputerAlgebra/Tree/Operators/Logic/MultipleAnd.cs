using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Op;

namespace AIRLab.CA.Tree.Operators.Logic
{
    public class MultipleAnd : MultipleOperator, INode<bool>
    {
        public MultipleAnd(params INode[] childs)
            : base(typeof(bool), System.Linq.Expressions.Expression.AndAlso, " Λ ", childs)
        { }
    }
}