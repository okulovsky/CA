// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AIRLab.CA.Tests.TreeTests
{
    [TestClass]
    public class SimpleLogicTests : Tests
    {
        #region Logic
        //&&0
        [TestMethod]
        public void AndZero()
        {
            INode root = new And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                bool.FalseString,
                SimplifyLogicTree(root).ToString());
        }
        //&&1
        [TestMethod]
        public void AndOne()
        {
            INode root = new And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }
        //||0
        [TestMethod]
        public void OrZero()
        {
            INode root = new Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }
        //||1
        [TestMethod]
        public void OrOne()
        {
            INode root = new Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                bool.TrueString,
                SimplifyLogicTree(root).ToString());
        }
        //!!
        [TestMethod]
        public void DoubleNot()
        {
            INode root = new Not(new Not(VariableNode.Make<bool>(0, "x")));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }

        //x V x
        [TestMethod]
        public void XOrX()
        {
            INode root = new Or(VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }

        //!x V x
        [TestMethod]
        public void XOrNotX()
        {
            INode root = new Or(new Not(VariableNode.Make<bool>(0, "x")), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                new Constant<bool>(true).ToString(),
                SimplifyLogicTree(root).ToString());
        }
        
        #endregion
    }
    
}
