using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AIRLab.CA;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace SimplificationDemo
{
    class SimplificationDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter the expression like '(3*x+y^2)*z' or type 'r' to generate random expression:");
            try
            {
                while (true)
                {
                    var formula = Console.ReadLine();
                    var node = formula.Equals("r")
                                   ? new SampleGenerator(2, 6, 0.0).GetFormula()
                                   : String2Tree.Parse(formula);
                    Console.WriteLine("Parsed tree:\n" + node);
                    Console.WriteLine("Press any key to simplify...");
                    Console.ReadKey(true);
                    var result = ComputerAlgebra.Simplify(node);
                    Console.WriteLine("Result of simplification:\n " + result);
                    Console.Write("\nContinue? (y/n):");
                    var key = Console.ReadKey();
                    if(key.Equals(ConsoleKey.N))
                    {
                        break;
                    }
                    Console.ReadKey();
                    Console.WriteLine("\nType new expression: ");
                }
            }
            catch (CAException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
        }
    }
}
