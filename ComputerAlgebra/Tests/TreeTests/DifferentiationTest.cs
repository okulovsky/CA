using System;
using System.Linq.Expressions;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;
using NUnit.Framework;

namespace AIRLab.CA.Tests
{
    [TestFixture]
    class DifferentiationTest : Tests
    {
        // (-x) dif x => -1
        [Test]
        public void DiffNegate()
        {
            Expression<del1> expression = (x) => -x;
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(expression.Body, variable: "x").ToString(),
                "-1");
        }

        // (x+y) dif x => 1
        [Test]
        public void DiffPlus()
        {
            Expression<del2> expression = (x, y) => x + y;
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(expression.Body, variable: "x").ToString(),
                "1");
        }
        // (x-y) dif x => 1
        [Test]
        public void DiffMinus()
        {
            Expression<del2> expression = (x, y) => x - y;
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(expression.Body, variable: "x").ToString(),
                "1");
        }
        // (x*y) dif x => y
        [Test]
        public void DiffProduct()
        {
            Expression<del2> expression = (x, y) => x * y;
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(expression.Body, variable: "x").ToString(),
                "y");
        }
        // (x/y) dif x => y/y^2
        [Test]
        public void DiffDivide()
        {
            Expression<del2> expression = (x, y) => x / y;
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(Expressions2Tree.Parse(expression.Body), variable: "x").ToString(),
                new Arithmetic.Divide<double>(
                    VariableNode.Make<double>(1, "y"),
                    new Arithmetic.Pow<double>(VariableNode.Make<double>(1, "y"), Constant.Double(2))).ToString());
        }

        // (x^C) dif x => C*x^(C-1)
        [Test]
        public void DiffPowConstant()
        {
            Expression<del1> expression = (x) => Math.Pow(x, 3);
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(Expressions2Tree.Parse(expression.Body), variable: "x").ToString(),
                new Arithmetic.Product<double>(Constant.Double(3.0), new Arithmetic.Pow<double>(VariableNode.Make<double>(0, "x"), Constant.Double(2.0))).ToString());
        }

        // (Ln(x)) dif x => 1/x
        [Test]
        public void DiffLn()
        {
            Expression<del1> expression = (x) => Math.Log(x);
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(Expressions2Tree.Parse(expression.Body), variable: "x").ToString(),
                new Arithmetic.Divide<double>(Constant.Double(1.0), VariableNode.Make<double>(0, "x")).ToString());
        }
        
        // (x^y) dif x => ((x^y)*(y/y))
        [Test]
        public void DiffPowX()
        {
            Expression<del2> expression = (x, y) => Math.Pow(x, y);
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(Expressions2Tree.Parse(expression.Body), variable: "x").ToString(),
                new Arithmetic.Product<double>(
                    new Arithmetic.Pow<double>(
                        VariableNode.Make<double>(0, "x"),
                        VariableNode.Make<double>(1, "y")),
                    new Arithmetic.Divide<double>(
                        VariableNode.Make<double>(1, "y"),
                        VariableNode.Make<double>(0, "x"))).ToString());
        }
        // (x^y) dif y => ((x^y)*(Ln(y)))
        [Test]
        public void DiffPowY()
        {
            Expression<del2> expression = (x, y) => Math.Pow(x, y);
            Assert.AreEqual(
                ComputerAlgebra.Differentiate(Expressions2Tree.Parse(expression.Body), variable: "y").ToString(),
                new Arithmetic.Product<double>(
                    new Arithmetic.Pow<double>(
                        VariableNode.Make<double>(0, "x"),
                        VariableNode.Make<double>(1, "y")),
                    new Arithmetic.Ln(VariableNode.Make<double>(0, "x")))
                    .ToString());
        }
    }
}
