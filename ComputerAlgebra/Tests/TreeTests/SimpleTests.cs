// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using AIRLab.CA.Tree;
using NUnit.Framework;
using System.Linq.Expressions;

namespace AIRLab.CA.Tests
{
    [TestFixture]
    public class SimpleTests : Tests
    {
        #region Algebraic
        // +0                
        [Test]
        public void PlusZero()
        {
            Expression<del1> expression = x => x + 0;
            Assert.AreEqual(SimplifyBinaryExpression(expression.Body).ToString(), "x");
        }        
        // -0        
        [Test]
        public void MinusZero()
        {
            Expression<del1> expression = x => x - 0;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "x");
        }        
        // *0        
        [Test]
        public void ProductZero()
        {
            Expression<del1> expression = x => x * 0;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "0");
        }
        // 0/        
        [Test]
        public void ZeroDivide()
        {
            Expression<del1> expression = x => 0 / x;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "0");
        }       
        // ^0        
        [Test]
        public void PowZero()
        {
            Expression<del1> expression = x => Math.Pow(x, 0);            
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "1");
        }       
        // 0^        
        [Test]
        public void ZeroPow()
        {
            Expression expression = Expression.Power(Expression.Constant(0.0), Expression.Parameter(typeof(double), "x"));
            Assert.AreEqual(
                SimplifyBinaryExpression(expression).ToString(), "0");
        }
        // *1        
        [Test]
        public void ProductOne()
        {
            Expression<del1> expression = x => x * 1;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "x");
        }
        // /1        
        [Test]
        public void DivideOne()
        {
            Expression<del1> expression = x => x / 1;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "x");
        }
        // ^1        
        [Test]
        public void PowOne()
        {
            Expression<del1> expression = x => Math.Pow(x, 1);
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "x");
        }
        // C+C       
        [Test]
        public void ConstPlus()
        {
            Expression<del> expression = () => 2 + 1;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "3");
        }
        // C-C       
        [Test]
        public void ConstMinus()
        {
            Expression<del> expression = () => 2 - 1;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "1");
        }
        // C*C       
        [Test]
        public void ConstProduct()
        {
            Expression<del> expression = () => 2 * 2;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "4");
        }
        // C/C       
        [Test]
        public void ConstDivide()
        {
            Expression<del> expression = () => 4 / 2;
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "2");
        }
        // C^C       
        [Test]
        public void ConstPow()
        {
            Expression<del> expression = () => Math.Pow(2, 2);
            Assert.AreEqual(
                SimplifyBinaryExpression(expression.Body).ToString(), "4");
        }
        #endregion

        #region Logic
        //&&0
        [Test]
        public void AndZero()
        {
            INode root = new Logic.And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), bool.FalseString);
        }
        //&&1
        [Test]
        public void AndOne()
        {
            INode root = new Logic.And(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), VariableNode.Make<bool>(0, "x").ToString());
        }
        //||0
        [Test]
        public void OrZero()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(false));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), VariableNode.Make<bool>(0, "x").ToString());
        }
        //||1
        [Test]
        public void OrOne()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), new Constant<bool>(true));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), bool.TrueString);
        }
        //!!
        [Test]
        public void DoubleNot()
        {
            INode root = new Logic.Not(new Logic.Not(VariableNode.Make<bool>(0, "x")));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), VariableNode.Make<bool>(0, "x").ToString());
        }

        //x V x
        [Test]
        public void XOrX()
        {
            INode root = new Logic.Or(VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), VariableNode.Make<bool>(0, "x").ToString());
        }

        //!x V x
        [Test]
        public void XOrNotX()
        {
            INode root = new Logic.Or(new Logic.Not(VariableNode.Make<bool>(0, "x")), VariableNode.Make<bool>(0, "x"));
            Assert.AreEqual(
                SimplifyLogicTree(root).ToString(), Constant.Bool(true).ToString());
        }
        

        #endregion
    }
    
}
