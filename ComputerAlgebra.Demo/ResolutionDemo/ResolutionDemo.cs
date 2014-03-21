// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Tools;
using AIRLab.CA;
using AIRLab.CA.Tree.Rules;
using AIRLab.CA.Tree.Tools;

namespace ResolutionDemo
{
    class ResolutionDemo : LogicExpressions
    {
        static void Main()
        {
            //Type two clauses in SNF without quantifiers
            Expression<Func<int,int,int,int,ComputerAlgebraBoolean>> exp = (x, y, z, u) => !P(x, y) | Q(z, g(u)) | R(z, f(u));
            Expression<Func<int, int, ComputerAlgebraBoolean>> gypotesis = (x, u) => !R(x, f(u)) | P(b, h(a));

            var expNode = Expressions2LogicTree.Parse(exp);
            var gypotesisNode = Expressions2LogicTree.Parse(gypotesis);
            Console.WriteLine("First clause: {0}", expNode);
            Console.WriteLine("Second clause: {0}", gypotesisNode);
            var result = ComputerAlgebra.Resolve(expNode, gypotesisNode).ToList();
            Console.WriteLine("Possible resolvents: [{0}]", string.Join(" ; ", result));
        }
    }
}
