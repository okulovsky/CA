// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Linq.Expressions;
using AIRLab.CA.ExpressionConverters;
using AIRLab.CA.Tree.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AIRLab.CA.Tests.TreeTests
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
