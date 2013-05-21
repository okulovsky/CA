using System;
using AIRLab.CA;
using AIRLab.CA.Regression;
using AIRLab.CA.Tree;

namespace CADemo
{
    class RegressionDemo
    {
        private const double NoiseLevel = 0.1;
        private static readonly Random Rnd = new Random();

        static void Main()
        {
            var generator = new SampleGenerator(2, 6, 0.001);
            var randomFormula = generator.GetFormula();
            Console.WriteLine(String.Format("Formula before noise constants: {0}", randomFormula));
            NoisyConstants(randomFormula);
            Console.WriteLine(String.Format("Formula after: {0}", randomFormula));
            var alg = new RegressionAlgorithm(randomFormula, generator.InSamples, generator.ExactResult);
            Console.WriteLine("Press any key to start regression...");
            Console.ReadKey();
            ConsoleGui.Run(alg, 5, "", 1000, 2);
            Console.WriteLine("Result: " + alg.GetResult());
            Console.ReadKey();
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
