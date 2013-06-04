// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq.Expressions;
using AIRLab.CA;
using AIRLab.CA.Tools;

namespace SimplificationDemo
{
    class SimplificationDemo
    {
        protected delegate double del4(double p1, double p2, double p3, double p4);
        static void Main()
        {
           try
            {
               //Type the function you want to simplify
                Expression<del4> function = (x, y, z, u) => (x+42)/1 + y*0/(z-0) + 43 - Math.Pow(x, 0) * Math.Pow(u, 1)/(0+5);
                var node = Expressions2Tree.Parse(function);
                Console.WriteLine("Initial function:\nF(x,y,z,u) = " + node);
                
                // Simplification
                var result = ComputerAlgebra.Simplify(node);
                Console.WriteLine("Result of simplification:\n" + result);

                Console.ReadKey();
            }
            catch (CAException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
        }
    }
}
