// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using AIRLab.CA;
using AIRLab.CA.Regression;
using AIRLab.CA.Tree;
using AIRLab.CA.Tree.Nodes;

namespace CADemo
{
    class RegressionDemo
    {
        private const double NoiseLevel = 0.1;
        private static readonly Random RandomNumberGenerator = new Random();

        static void Main()
        {
            var sampleGenerator = new SampleGenerator(2, 6, 0.001);
            var randomFormula = sampleGenerator.GetFormula();
            Console.WriteLine("Formula before making constants noisy: {0}", randomFormula);

            GenerateNoisyConstantsForNodeLeafes(randomFormula);
            Console.WriteLine("Formula after making constants noisy: {0}", randomFormula);
            
            Console.WriteLine("Press any key to start regression...");
            Console.ReadKey(true);

            var alg = new RegressionAlgorithm(randomFormula, sampleGenerator.InSamples, sampleGenerator.ExactResult);
            ConsoleGui.Run(alg, 5, "");
            
            Console.WriteLine("Result: {0}", alg.GetResult());
        }

        private static void GenerateNoisyConstantsForNodeLeafes(INode node)
        {
            if (node.HasChildren())
            {
                node.Children.ToList().ForEach(GenerateNoisyConstantsForNodeLeafes);
                return;
            }

            if (!(node is Constant))
                return;

            var childIndex = node.Parent.IndexOfChild(node);
            node.Parent.Children[childIndex] = CalculateNewConstant((Constant<double>)node);
        }

        private static Constant<double> CalculateNewConstant(Constant<double> constant)
        {
            var oldValue = constant.Value;
            var newValue = oldValue + 
                Math.Pow((-1), RandomNumberGenerator.Next(3)) *
                RandomNumberGenerator.Next((int) (oldValue/2), (int) (oldValue*2)) * 
                NoiseLevel;
            return new Constant<double>(newValue);
        }
    }
}
