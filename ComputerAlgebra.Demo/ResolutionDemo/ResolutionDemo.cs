using System;
using System.Linq;
using System.Linq.Expressions;
using AIRLab.CA.Resolution;
using AIRLab.CA.Rules;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace ResolutionDemo
{
    class ResolutionDemo : LogicExpressions
    {
        delegate CABoolean del1(int x);
        delegate CABoolean del4(int x, int y, int z, int u);

        static void Main()
        {
            Expression<del4> exp = (x, y, z, u) => !P(x, y) | Q(z, g(u)) | R(z, f(u));
            Expression<del1> gypotesis = (u) => !R(a, f(u));
            var expNode = Expressions2LogicTree.Parse(exp);
            var gypotesisNode = Expressions2LogicTree.Parse(gypotesis);
            Console.WriteLine("First argument: " + expNode);
            Console.WriteLine("Second argument: " + gypotesisNode);
            var result = ResolutionService.Resolve(expNode, gypotesisNode).ToList();
            Console.WriteLine("Result: ["+string.Join(" ; ", result) + "]");
            Console.ReadKey();
        }
    }
}
