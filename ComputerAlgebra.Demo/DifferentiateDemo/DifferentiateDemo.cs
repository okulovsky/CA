// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using AIRLab.CA;
using AIRLab.CA.Tools;

namespace DifferentiateDemo
{
    class DifferentiateDemo
    {
        protected delegate double del3(double p1, double p2, double p3);
        static void Main()
        {
            try
            {
                //Type the function you want to differentiate
                Expression<del3> function = (x, y, z) => Math.Pow(x, 3)*y - Math.Pow(x, y)+5*z;
                var node = Expressions2Tree.Parse(function);
                Console.WriteLine("Initial function:\nF(x,y,z) = " + node);

                // Differentiation
                Console.Write("\ndF/dx = ");
                var result = ComputerAlgebra.Differentiate(node, variable : "x");
                Console.WriteLine(result);

                Console.Write("\ndF/dy = ");
                result = ComputerAlgebra.Differentiate(node, variable: "y");
                Console.WriteLine(result);

                Console.Write("\ndF/dz = ");
                result = ComputerAlgebra.Differentiate(node, variable: "z");
                Console.WriteLine(result);

                Console.ReadKey();
            } catch(CAException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
