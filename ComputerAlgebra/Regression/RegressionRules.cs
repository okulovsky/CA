// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System.Collections.Generic;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Rules;
using AIRLab.CA.Tree.RulesCollection;

namespace AIRLab.CA.Regression
{
    public class RegressionRules : SelectClauseWriter
    {
        public static int IterationCount;

        public static IEnumerable<IRule> Get(IList<double[]> inSample, IList<double> exactResult)
        {
            yield return Rule
                .New("Regression", StdTags.Regression, StdTags.Algebraic)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => Modificator(z, inSample, exactResult, IterationCount));
        }

        private static void Modificator(ITypizedDecorArray<INode<double>> z, IList<double[]> inSample, IList<double> exactResult, int iterationCount)
        {
            var alg = new RegressionAlgorithm(z.A.Node, inSample, exactResult);
            alg.Run(iterationCount); 
            z.A.Replace(alg.GetResult());
        }
    }
}