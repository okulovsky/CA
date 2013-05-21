// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using AIRLab.CA.Regression;
using AIRLab.CA.Tree;
using NUnit.Framework;
using AIRLab.CA.Tools;

namespace AIRLab.CA.Tests
{
    [TestFixture]
    public class RegressionTests
    {
        private const double NoiseLevel = 0.01;
        private static readonly Random Rnd = new Random();

        [Test]
        public void TwoVarsTreeOps()
        {
            var service = new SampleGenerator(2, 3, 0.001);
            var formula = service.GetFormula();
            var noiseFormula = formula.Clone<INode>();
            NoisyConstants(noiseFormula);
            var alg = new RegressionAlgorithm(noiseFormula, service.InSamples, service.ExactResult);
            alg.Run();
            Assert.AreNotEqual(alg.GetResult(), null);  
        }

        private static void NoisyConstants(INode node)
        {
            if (node.HasChildren())
            {
                foreach (var child in node.Children)
                {
                    NoisyConstants(child);
                }
            }
            else
            {
                if (node is Constant)
                {
                    var oldValue = ((Constant<double>)node).Value;
                    var childIndex = node.Parent.IndexOfChild(node);
                    INode newConst = new Constant<double>(oldValue + Math.Pow((-1), Rnd.Next(3)) * Rnd.Next((int)(oldValue / 2), (int)(oldValue * 2)) * NoiseLevel);
                    node.Parent.Children[childIndex] = newConst;
                }
            }
        }
    }    
}
