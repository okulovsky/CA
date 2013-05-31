// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using AIRLab.CA.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TreeTests
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void TreeHasCorrectStringForm()
        {
            var tree = new Arithmetic.Product<int>(VariableNode.Make<int>(0, "x"),
                                                   new Arithmetic.Plus<int>(VariableNode.Make<int>(1, "y"),
                                                                            Constant.Int(3)));
            Assert.AreEqual(tree.ToString(), "(x ∙ (y + 3))");
            var tree2 = new Logic.MultipleOr(new PredicateNode("P", VariableNode.Make<int>(0, "x")),
                                                new PredicateNode("Q", VariableNode.Make<int>(1, "y"), VariableNode.Make<int>(2, "z")),
                                                new PredicateNode("H", new FunctionNode("f", VariableNode.Make<int>(0, "x")), new FunctionNode("c")));
            Assert.AreEqual(tree2.ToString(), "P(x) V Q(y,z) V H(f(x),c)");
        }

        [TestMethod]
        public void NodesKeepProperInfo()
        {
            var constant = Constant.Int(1);
            Assert.AreEqual(1, constant.Value);
            Assert.AreEqual(typeof(int), constant.Type);
            Assert.AreEqual(0, constant.Children.Length);

            var variable = VariableNode.Make<int>(0, "x");
            Assert.AreEqual(0, variable.Index);
            Assert.AreEqual(typeof(int), variable.Type);
            Assert.AreEqual(0, variable.Children.Length);

            var op = new Arithmetic.Plus<int>(constant, variable);
            Assert.AreEqual(op.Children.Length, 2);
            Assert.AreEqual(op.Type, typeof(int));
            Assert.AreEqual(op.Parent, null);
            Assert.AreEqual(variable.Parent, op);
            Assert.AreEqual(constant.Parent, op);
        }
    }
}
