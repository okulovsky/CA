// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Arithmetic;
using AIRLab.CA.Tree.Operators.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TreeTests
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void TreeHasCorrectStringForm()
        {
            var tree = new ScalarProduct<int>(VariableNode.Make<int>(0, "x"),
                                                   new Addition<int>(VariableNode.Make<int>(1, "y"),
                                                                            Constant.Int(3)));
            Assert.AreEqual("(x ∙ (y + 3))", tree.ToString());
            var tree2 = new MultipleOr(new PredicateNode("P", VariableNode.Make<int>(0, "x")),
                                                new PredicateNode("Q", VariableNode.Make<int>(1, "y"), VariableNode.Make<int>(2, "z")),
                                                new PredicateNode("H", new FunctionNode("f", VariableNode.Make<int>(0, "x")), new FunctionNode("c")));
            Assert.AreEqual("P(x) V Q(y,z) V H(f(x),c)", tree2.ToString());
        }

        [TestMethod]
        public void NodesKeepProperInfo()
        {
            var constant = Constant.Int(1);
            Assert.AreEqual(constant.Value, 1);
            Assert.AreEqual(constant.Type, typeof(int));
            Assert.AreEqual(constant.Children.Length, 0);

            var variable = VariableNode.Make<int>(0, "x");
            Assert.AreEqual(variable.Index, 0);
            Assert.AreEqual(variable.Type, typeof(int));
            Assert.AreEqual(variable.Children.Length, 0);

            var op = new Addition<int>(constant, variable);
            Assert.AreEqual(op.Children.Length, 2);
            Assert.AreEqual(op.Type, typeof(int));
            Assert.AreEqual(op.Parent, null);
            Assert.AreEqual(variable.Parent, op);
            Assert.AreEqual(constant.Parent, op);
        }
    }
}
