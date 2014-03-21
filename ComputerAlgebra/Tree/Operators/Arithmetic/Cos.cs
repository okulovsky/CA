using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Cos : UnaryFunction, INode<double>
    {
        public Cos(INode child)
            : base(typeof(double), child, typeof(Math).GetMethod("Cos"), "\\cos")
        { }
    }
}