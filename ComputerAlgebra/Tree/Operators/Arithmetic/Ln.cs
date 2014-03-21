using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    /// <summary>
    /// Natural logarithm
    /// </summary>
    public class Ln : UnaryFunction, INode<double>
    {
        public Ln(INode child)
            : base(typeof(double), child, typeof(Math).GetMethod("Log", new Type[] {typeof(double)}), "\\ln")
        { }
    }
}