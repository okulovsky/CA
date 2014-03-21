using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Operators.Arithmetic
{
    public class Sin : UnaryFunction, INode<double>
    {
        public Sin(INode child)
            : base(typeof(double), child, typeof(Math).GetMethod("Sin"), "\\sin")
        { }
    }
}