using System.Linq.Expressions;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Comparison
{
    public class Equal : BinaryOperator, INode<bool>
        {
            public Equal(INode child1, INode child2)
                : base(typeof(bool), child1, child2, Expression.Equal, "=", false)
            { }
        }
}