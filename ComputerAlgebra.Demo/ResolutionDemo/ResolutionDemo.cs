// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Rules;
using AIRLab.CA.Tools;
using AIRLab.CA;

namespace ResolutionDemo
{
    class ResolutionDemo : LogicExpressions
    {
        delegate CABoolean del2(int x, int y);
        delegate CABoolean del4(int x, int y, int z, int u);

        static void Main()
        {
            //Type two clauses in SNF without quantifiers
            Expression<del4> exp = (x, y, z, u) => !P(x, y) | Q(z, g(u)) | R(z, f(u));
            Expression<del2> gypotesis = (x, u) => !R(x, f(u)) | P(b, h(a));

            var expNode = Expressions2LogicTree.Parse(exp);
            var gypotesisNode = Expressions2LogicTree.Parse(gypotesis);
            Console.WriteLine("First clause: " + expNode);
            Console.WriteLine("Second clause: " + gypotesisNode);
            var result = ComputerAlgebra.Resolve(expNode, gypotesisNode).ToList();
            Console.WriteLine("Possible resolvents: ["+string.Join(" ; ", result) + "]");
            Console.ReadKey();
        }
    }
}
