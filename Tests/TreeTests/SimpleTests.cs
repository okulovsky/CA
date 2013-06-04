// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using AIRLab.CA.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TreeTests
{
    [TestClass]
    public class SimpleTests : Tests
    {
        #region Algebraic
        // +0                
        [TestMethod]
        public void PlusZero()
        {
            Expression<del1> expression = x => x + 0;
            Assert.AreEqual(
                "x",
                SimplifyBinaryExpression(expression).ToString());
        }        
        // -0        
        [TestMethod]
        public void MinusZero()
        {
            Expression<del1> expression = x => x - 0;
            Assert.AreEqual(
                "x",
                SimplifyBinaryExpression(expression).ToString());
        }
        // 0-        
        [TestMethod]
        public void ZeroMinus()
        {
            Expression<del1> expression = x => 0 - x;
            Assert.AreEqual(
                "(-x)",
                SimplifyBinaryExpression(expression).ToString());
        }    
        // *0        
        [TestMethod]
        public void ProductZero()
        {
            Expression<del1> expression = x => x * 0;
            Assert.AreEqual(
                "0",
                SimplifyBinaryExpression(expression).ToString());
        }
        // 0/        
        [TestMethod]
        public void ZeroDivide()
        {
            Expression<del1> expression = x => 0 / x;
            Assert.AreEqual(
                "0",
                SimplifyBinaryExpression(expression).ToString());
        }       
        // ^0        
        [TestMethod]
        public void PowZero()
        {
            Expression<del1> expression = x => Math.Pow(x, 0);            
            Assert.AreEqual(
                "1",
                SimplifyBinaryExpression(expression).ToString());
        }       
        // 0^        
        [TestMethod]
        public void ZeroPow()
        {
            Expression expression = Expression.Power(Expression.Constant(0.0), Expression.Parameter(typeof(double), "x"));
            Assert.AreEqual(
                "0",
                SimplifyBinaryExpression(expression).ToString());
        }
        // *1        
        [TestMethod]
        public void ProductOne()
        {
            Expression<del1> expression = x => x * 1;
            Assert.AreEqual(
                "x",
                SimplifyBinaryExpression(expression).ToString());
        }
        // /1        
        [TestMethod]
        public void DivideOne()
        {
            Expression<del1> expression = x => x / 1;
            Assert.AreEqual(
                "x",
                SimplifyBinaryExpression(expression).ToString());
        }
        // ^1        
        [TestMethod]
        public void PowOne()
        {
            Expression<del1> expression = x => Math.Pow(x, 1);
            Assert.AreEqual(
                "x",
                SimplifyBinaryExpression(expression).ToString());
        }
        // (-0)        
        [TestMethod]
        public void NegateZero()
        {
            Expression<del> expression = () => -0;
            Assert.AreEqual(
                "0",
                SimplifyBinaryExpression(expression).ToString());
        }
        // C+C       
        [TestMethod]
        public void ConstPlus()
        {
            Expression<del> expression = () => 2 + 1;
            Assert.AreEqual(
                "3",
                SimplifyBinaryExpression(expression).ToString());
        }
        // C-C       
        [TestMethod]
        public void ConstMinus()
        {
            Expression<del> expression = () => 2 - 1;
            Assert.AreEqual(
                "1",
                SimplifyBinaryExpression(expression).ToString());
        }
        // C*C       
        [TestMethod]
        public void ConstProduct()
        {
            Expression<del> expression = () => 2 * 2;
            Assert.AreEqual(
                "4",
                SimplifyBinaryExpression(expression).ToString());
        }
        // C/C       
        [TestMethod]
        public void ConstDivide()
        {
            Expression<del> expression = () => 4 / 2;
            Assert.AreEqual(
                "2",
                SimplifyBinaryExpression(expression).ToString());
        }
        // C^C       
        [TestMethod]
        public void ConstPow()
        {
            Expression<del> expression = () => Math.Pow(2, 2);
            Assert.AreEqual(
                "4",
                SimplifyBinaryExpression(expression).ToString());
        }

        // (x+C)+C       
        [TestMethod]
        public void XPlusConstPlusConst()
        {
            Expression<del1> expression = (x) => (x + 5) + 5;
            Assert.AreEqual(
                "(x + 10)",
                SimplifyBinaryExpression(expression).ToString());
            expression = (x) => 3+(x+1);
            Assert.AreEqual(
                "(x + 4)",
                SimplifyBinaryExpression(expression).ToString());
        }

        // (x-C)+C      
        [TestMethod]
        public void XMinusConstPlusConst()
        {
            Expression<del1> expression = (x) => (x - 5) + 5;
            Assert.AreEqual(
                "x", 
                SimplifyBinaryExpression(expression).ToString());
            expression = (x) => 3 + (x - 1);
            Assert.AreEqual(
                "(x + 2)",
                SimplifyBinaryExpression(expression).ToString());
            expression = (x) => 3 + (1 - x);
            Assert.AreNotEqual(
                "(x + 2)",
                SimplifyBinaryExpression(expression).ToString());
        }
        #endregion

        #region Logic
        //&&0
        [TestMethod]
        public void AndZero()
        {
            INode root = new Logic.And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                bool.FalseString,
                SimplifyLogicTree(root).ToString());
        }
        //&&1
        [TestMethod]
        public void AndOne()
        {
            INode root = new Logic.And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }
        //||0
        [TestMethod]
        public void OrZero()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }
        //||1
        [TestMethod]
        public void OrOne()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                bool.TrueString,
                SimplifyLogicTree(root).ToString());
        }
        //!!
        [TestMethod]
        public void DoubleNot()
        {
            INode root = new Logic.Not(new Logic.Not(VariableNode.Make<bool>(0, "x")));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }

        //x V x
        [TestMethod]
        public void XOrX()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                VariableNode.Make<bool>(0, "x").ToString(),
                SimplifyLogicTree(root).ToString());
        }

        //!x V x
        [TestMethod]
        public void XOrNotX()
        {
            INode root = new Logic.Or(new Logic.Not(VariableNode.Make<bool>(0, "x")), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                Constant.Bool(true).ToString(),
                SimplifyLogicTree(root).ToString());
        }
        

        #endregion
    }
    
}
