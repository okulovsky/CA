// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using AIRLab.CA.Regression;

namespace AIRLab.CA
{
    public static class ConsoleGui
    {
        public static void Run(RegressionAlgorithm regressionAlgorithm, int iterationShowRate, String formula, int iterationCount = 1000, int iterationCursorPosition = 2)
        {
            Console.SetCursorPosition(0, iterationCursorPosition);
            Console.WriteLine("Functional: {0}", regressionAlgorithm.Formula);

            for (var count = 0; regressionAlgorithm.CurrentIteration < iterationCount; count++)
            {
                regressionAlgorithm.MakeIteration();
                if (count % iterationShowRate != 0) 
                    continue;

                Console.SetCursorPosition(0, iterationCursorPosition+2);
                Console.WriteLine("Iteration #:\t{0}", regressionAlgorithm.CurrentIteration);
                Console.WriteLine("Constant set:\t[{0}]", string.Join(" ; ", regressionAlgorithm.InConstant));
                Console.WriteLine("ApproximationError:\t{0}", regressionAlgorithm.ApproximationError);
            }
        }
    }
}
