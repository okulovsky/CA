// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;
using NUnit.Framework;

namespace AIRLab.CA.Tests
{
    [TestFixture]
    public class RulesTest : SelectClauseWriter
    {
        INode _root1 =
                new TestOp(
                    new TestOp(
                        new TestOp(
                            new TestOp())),
                    new TestOp(
                        new TestOp(
                            new TestOp(),
                            new TestOp()),
                        new TestOp(
                            new TestOp(),
                            new TestOp(),
                            new TestOp())));

        INode _root2 =
            new TestOp(
                new TestOp(
                    new TestOp(),
                    new TestOp()),
                new TestOp(
                    new TestOp()));

        [Test]
        public void Test()
        {
            Test(12, AnyA, _root1);
            Test(26, AnyA[AnyB], _root1);
            Test(162, AnyA[AnyB, AnyC], _root1);
            Test(21, AnyA[AnyB[AnyC]], _root1);
            Test(11, AnyA[ChildB], _root1);
            Test(12, AnyA[ChildB, ChildC], _root1);
            Test(2, AnyA[B], _root1);
            Test(3, AnyA[B, C], _root1);

            Test(72, AnyA, AnyB, _root1, _root2);
            Test(55, AnyA[ChildB], AnyC[ChildD], _root1, _root2);
            Test(1, A, B, _root1, _root2);
            Test(1, A, _root1);
        }

        static void Test(int expectedCount, params object[] q)
        {
            var num = q.Length / 2;
            var clauses = q.Take(num).Select(z => (SelectClauseNode) z).ToArray();
            var roots = q.Skip(num).Select(z => (INode) z).ToArray();
            var selector = new ComplexSelector(clauses);
            Assert.That(selector.Select(roots).Count() == expectedCount);
        }
    }

    public class TestOp : Node
    {
        static int _currentNumber;
        private readonly int _number;

        public TestOp(params TestOp[] children)
            : base(children)
        {
            _number = _currentNumber;
            _currentNumber++;
        }

        public override string ToString()
        {
            var result = ToLetter().ToString();
            if (this.HasChildren())
            {
                result += "(";
                for (var i = 0; i < Children.Length; i++)
                    result += (i == 0 ? "" : ",") + Children[i];
                result += ")";
            }
            return result;
        }

        private char ToLetter()
        {
            return ((char)('a' + _number));
        }

        public override Expression BuildExpression()
        {
            throw new NotImplementedException();
        }
    }
}
