using System;

namespace AIRLab.CA.Regression
{
    public static class ConsoleGui
    {
        public static void Run(RegressionAlgorithm alg, int iterationShowRate, String formula, int iterationCount = 1000, int iterationCursorPosition = 2)
        {
            Console.SetCursorPosition(0, iterationCursorPosition);
            Console.WriteLine("Functional: " + alg.Formula);

            for (var cnt = 0; ; cnt++)
            {
                alg.MakeIteration();
                if (cnt % iterationShowRate != 0) continue;
                Console.SetCursorPosition(0, iterationCursorPosition+2);
                Console.WriteLine("Iteration #:  " + alg.CurrentIteration);
                Console.WriteLine("Constant set:  " + "[" + string.Join(" ; ", alg.InConstant) + "]");
                Console.WriteLine("ApproximationError:    " + alg.ApproximationError);
                
                if (alg.CurrentIteration > iterationCount) break;
            }
        }
    }
}
