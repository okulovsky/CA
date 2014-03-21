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
        static void Main()
        {
            //Type the function you want to simplify
            Expression<Func<double, double, double, double, double>> function = 
                (x, y, z, u) => (x+42)/1 + y*0/(z-0) + 43 - Math.Pow(x, 0) * Math.Pow(u, 1)/(0+5);

            var tree = Expressions2Tree.Parse(function);
            var simplifiedTree = ComputerAlgebra.Simplify(tree);

            Console.WriteLine("Initial function:{1}F(x,y,z,u) = {0}{1}", tree, Environment.NewLine);
            Console.WriteLine("Result of simplification:{1}{0}", simplifiedTree, Environment.NewLine);
        }
    }
}
