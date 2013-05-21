using System;
using AIRLab.CA;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace DifferentiateDemo
{
    class DifferentiateDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the expression like '(3*x+y^2)*z':");
                var formula = Console.ReadLine();
                var node = String2Tree.Parse(formula);
                Console.WriteLine("Parsed tree:\n" + node);
                Console.WriteLine("Enter the variable for differentiation");
                var variable = Console.ReadLine();
                if(NodeElementNames.GetVariableNodeNames().IndexOf(variable) == -1)
                {
                    throw new CAException("Error! Incorrect variable for differentiation");
                }
                var result = ComputerAlgebra.Differentiate(node, variable : variable);
                Console.WriteLine("Result of differentiation:\n "+result);
                Console.ReadKey();
            } catch(CAException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
