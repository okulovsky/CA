using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Tan : UnaryFunction, INode<double>
    {
        public Tan(INode child)
            : base(typeof(double), child, typeof(Math).GetMethod("Tan"), "\\tan")
        { }
    }
}