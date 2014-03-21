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
        static void Main()
        {
            //Type the function you want to differentiate
            Expression<Func<double, double, double, double>> function = (x, y, z) => Math.Pow(x, 3) * y - Math.Pow(x, y) + 5 * z;
            var node = Expressions2Tree.Parse(function);

            // Differentiation
            var resultFromDiffX = ComputerAlgebra.Differentiate(node, variable : "x");
            var resultFromDiffY = ComputerAlgebra.Differentiate(node, variable: "y");
            var resultFromDiffZ = ComputerAlgebra.Differentiate(node, variable: "z");

            // Output
            Console.WriteLine("Initial function:{1}F(x,y,z) = {0}{1}", node, Environment.NewLine);
            Console.WriteLine("dF/dx = {0}{1}", resultFromDiffX, Environment.NewLine);
            Console.WriteLine("dF/dy = {0}{1}", resultFromDiffY, Environment.NewLine);
            Console.WriteLine("dF/dz = {0}{1}", resultFromDiffZ, Environment.NewLine);
        }
    }
}
