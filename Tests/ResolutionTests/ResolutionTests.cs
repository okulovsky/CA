// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA;
using AIRLab.CA.Resolution;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Logic;
using AIRLab.CA.Tree.Rules;
using AIRLab.CA.Tree.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.ResolutionTests
{
    [TestClass]
    public class ResolutionTests : LogicExpressions
    {
        delegate ComputerAlgebraBoolean Del1(int x);
        delegate ComputerAlgebraBoolean Del2(int x, int y);
        delegate ComputerAlgebraBoolean Del3(int x, int y, int z);

        [TestMethod]
        public void ParseTest()
        {
            Expression<Del1> e = (x) => !P(f(x)) | P(x);
            INode node = Expressions2LogicTree.Parse(e);
            Assert.AreEqual(new MultipleOr(new SkolemPredicateNode("P", true, new FunctionNode("f", VariableNode.Make<bool>(0, "x"))),
                                                                  new SkolemPredicateNode("P", false, VariableNode.Make<bool>(0, "x"))).ToString(),
                            node.ToString());
            Expression<Del3> e3 = (x, y, z) => P(f(x, y)) | !P(y) | P(x, y, z);
            node = Expressions2LogicTree.Parse(e3);
            Assert.AreEqual(new MultipleOr(new SkolemPredicateNode("P", false, new FunctionNode("f", VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(1, "y"))),
                                                                  new SkolemPredicateNode("P", true, VariableNode.Make<bool>(1, "y")),
                                                                  new SkolemPredicateNode("P", false, VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(1, "y"), VariableNode.Make<bool>(2, "z"))).ToString(),
                            node.ToString());
            Expression<Del1> e2 = (x) => P(f(x), a);
            node = Expressions2LogicTree.Parse(e2);
            Assert.AreEqual(new MultipleOr(new SkolemPredicateNode("P", false, 
                                                                        new FunctionNode("f", VariableNode.Make<bool>(0, "x")), 
                                                                        new FunctionNode("a"))).ToString(),
                            node.ToString());
        }

        [TestMethod]
        public void ResolveRuleTest()
        {
            // P(x) V Q(f(y))
            Expression<Del2> root = (x, y) => P(x) | Q(f(y));
            // !P(x)
            Expression<Del1> gypotesis = (x) => !P(x);
            var result = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(root), Expressions2LogicTree.Parse(gypotesis)).ToList();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Q(f(y))", result[0].ToString());
            result = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(gypotesis), Expressions2LogicTree.Parse(root)).ToList();
            Assert.AreEqual("Q(f(y))", result[0].ToString());
        }

        [TestMethod]
        public void PredicateAndNegatePredicate()
        {
            Expression<Del1> root = (x) => P(x);
            Expression<Del1> gypotesis = (x) => !P(x);

            var result =
                    ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(root), Expressions2LogicTree.Parse(gypotesis)).ToList();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("", result[0].ToString());
        }

        [TestMethod]
        public void ResolutionOnResultOfResolution()
        {
            Expression<Del1> f1 = (x) => P(x) | Q(x);
            Expression<Del1> f2 = (x) => !Q(x);
            Expression<Del1> f3 = (x) => !P(x);

            //P(x)
            var result = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(f1), Expressions2LogicTree.Parse(f2)).Single();
            //{} ?
            var result2 = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(f3), result).ToList();
            Assert.AreEqual(1, result2.Count);
            Assert.AreEqual("", result2[0].ToString());
        }

        [TestMethod]
        public void ResolveRuleMultipleTest()
        {
            Expression<Del1> node1 = (x) => P(x) | !Q(x) | R(x);
            Expression<Del1> node2 = (x) => !P(x) | Q(x) | !R(x);
            var result = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(node1), Expressions2LogicTree.Parse(node2));
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void UnificationTest()
        {
            // P(f(x), z)
            var A = new SkolemPredicateNode("P", false, new FunctionNode("f", VariableNode.Make<bool>(0, "x")),
                                      VariableNode.Make<bool>(2, "z"));
            // P(y,a)
            var B = new SkolemPredicateNode("P", false, VariableNode.Make<bool>(1, "y"), new FunctionNode("a"));
            Assert.AreEqual(true, UnificationService.CanUnificate(A,B));
            var rules = UnificationService.GetUnificationRules(A, B);
            Assert.AreEqual(2, rules.Count);
            UnificationService.Unificate(A, rules);
            UnificationService.Unificate(B, rules);
            Assert.AreEqual("P(f(x),a)", A.ToString());
            Assert.AreEqual(A.ToString(), B.ToString());
        }

        [TestMethod]
        public void HardUnificationTest()
        {
            // P(a,x,f(g(y))
            Expression<Del2> A = (x, y) => P(a, x, f(g(y)));
            // P(z,f(z),f(u))
            Expression<Del2> B = (z, u) => P(z, f(z), f(u));
            var node1 = (SkolemPredicateNode)Expressions2LogicTree.Parse(A).Children[0];
            var node2 = (SkolemPredicateNode)Expressions2LogicTree.Parse(B).Children[0];
            Assert.AreEqual(true, UnificationService.CanUnificate(node1, node2));
            var rules = UnificationService.GetUnificationRules(node1, node2);
            Assert.AreEqual(3, rules.Count);
            UnificationService.Unificate(node1, node2);
            Assert.AreEqual(node1.ToString(), node2.ToString());
        }

        [TestMethod]
        public void ErrorUnificationTest()
        {
            // Q(f(a),g(x))
            Expression<Del1> A = (x) => Q(f(a), g(x));
            // Q(y,y)
            Expression<Del1> B = (y) => Q(y, y);
            var node1 = (SkolemPredicateNode)Expressions2LogicTree.Parse(A).Children[0];
            var node2 = (SkolemPredicateNode)Expressions2LogicTree.Parse(B).Children[0];
            Assert.AreEqual(false, UnificationService.CanUnificate(node1, node2));
        }

        [TestMethod]
        public void ComplexUnificationTest()
        {
            // !P(x,b,z,s) V ANS(f(g(z,b,h(x,z,s))))
            var A = new MultipleOr(
                new SkolemPredicateNode("P", true, VariableNode.Make<bool>(0, "x"), new FunctionNode("b"), VariableNode.Make<bool>(2,"z"), VariableNode.Make<bool>(3, "s")),
                new SkolemPredicateNode("ANS", false,
                    new FunctionNode("f", 
                        new FunctionNode("g",VariableNode.Make<bool>(2, "z"),new FunctionNode("b"), 
                            new FunctionNode("h", VariableNode.Make<bool>(0, "x"), VariableNode.Make<bool>(2, "z"), VariableNode.Make<bool>(3, "s"))))));

            // P(a,b,c,s0)
            var B = new SkolemPredicateNode("P", false, new FunctionNode("a"), new FunctionNode("b"), new FunctionNode("c"), new FunctionNode("s0"));
            Assert.AreEqual(true, UnificationService.CanUnificate((SkolemPredicateNode)A.Children[0], B));
            var rules = UnificationService.GetUnificationRules((SkolemPredicateNode)A.Children[0], B);
            Assert.AreEqual(3, rules.Count);
            UnificationService.Unificate(A, rules);
            Assert.AreEqual("!P(a,b,c,s0) V ANS(f(g(c,b,h(a,c,s0))))", A.ToString());
        }

        [TestMethod]
        public void ResolveWithUnificateTest()
        {
            Expression<Del1> root = (x) => P(x) | Q(f(x));
            Expression<Del1> gypotesis = (z) => !P(g(z));
            var result = ComputerAlgebra.Resolve(Expressions2LogicTree.Parse(root), Expressions2LogicTree.Parse(gypotesis)).ToList();
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Q(f(g(z)))", result[0].ToString());
        }

        
    }
}
