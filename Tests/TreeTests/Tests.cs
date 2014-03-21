// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Linq.Expressions;
using AIRLab.CA;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TreeTests
{
    [TestClass]
    public class Tests
    {
        protected delegate double Del();
        protected delegate double Del1(double p);
        protected delegate double Del2(double p1, double p2);

        public static INode SimplifyBinaryExpression(Expression e)
        {
            return ComputerAlgebra.Simplify(Expressions2Tree.Parse(e));
        }

        public static INode SimplifyLogicTree(INode root)
        {
            return ComputerAlgebra.Simplify(root);
        }
    }
}
