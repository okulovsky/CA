// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using AIRLab.CA.Tree;
using NUnit.Framework;
using System.Linq.Expressions;
using AIRLab.CA.Tools;

namespace AIRLab.CA.Tests
{
    [TestFixture]
    public class ComplexTests : Tests
    {        
        // ((x+y)+0)*1 => x+y
        [Test]
        public void FirstLevel()
        {
            Expression<del2> expression = (x, y) => ((x + y) + 0) * 1;
            Assert.AreEqual(
                 SimplifyBinaryExpression(expression.Body).ToString(),
                 new Arithmetic.Plus<double>(VariableNode.Make<double>(0, "x"), VariableNode.Make<double>(1, "y")).ToString());
        }
        // ((((x^1)-0)-((3+2)+(0/1)))∙y) => (x-5)*y
        [Test]
        public void SecondLevel()
        {
            Expression<del2> expression = (x, y) => (((Math.Pow(x, 1)-0)-((3+2)+(0/1)))*y);
            Assert.AreEqual(
                 SimplifyBinaryExpression(expression.Body).ToString(),
                 new Arithmetic.Product<double>(
                     new Arithmetic.Minus<double>(
                         VariableNode.Make<double>(0, "x"), Constant.Double(5.0)), 
                     VariableNode.Make<double>(1, "y")).ToString());
        }
    }
}
