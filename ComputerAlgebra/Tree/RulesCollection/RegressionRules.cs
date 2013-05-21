// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using AIRLab.CA.Regression;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.RulesCollection
{
    public class RegressionRules : SelectClauseWriter
    {
        public static int IterationCount;

        public static IEnumerable<Rule> Get(List<double[]> inSample, List<double> exactResult)
        {
            yield return Rule
                .New("Regression", StdTags.Regression, StdTags.Algebraic)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => Modificator(z, inSample, exactResult, IterationCount));
        }

        private static void Modificator(TypizedDecorArray<INode<double>> z, List<double[]> inSample, List<double> exactResult, int iterationCount)
        {
            var alg = new RegressionAlgorithm(z.A.Node, inSample, exactResult);
            alg.Run(iterationCount); 
            z.A.Replace(alg.GetResult());
        }
    }
}