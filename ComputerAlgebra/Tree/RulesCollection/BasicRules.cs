// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.RulesCollection
{
    public class BasicRules : SelectClauseWriter
    {
        public static IEnumerable<Rule> CrossingRules()
        {
            yield return Rule
                .New("Subtree exchange")
                .Select(AnyA, AnyB)
                .Where<INode, INode>(z => z.A.Type == z.B.Type)
                .Mod(z => z.A.Replace(z.B.Node));    
        }
       
        public static IEnumerable<Rule> VariableRules(int count)
        {
            const string names = "xyzuvw";
            for (var i = 0; i < count; i++)
            {
                var t = i;
                yield return Rule
                    .New("Intro " + names[t], StdTags.Inductive, StdTags.UnsafeBlowing)
                    .Select(AnyA)
                    .Where<INode<double>>(z => z.A.Children.Length == 0)
                    .Mod(z => z.A.Replace(new VariableNode(typeof(double), t, names[t].ToString())));
            }
        }

        public static IEnumerable<Rule> MutationRules()
        {
            yield return Rule
                .New("Resection", StdTags.UnsafeResection)
                .Select(AnyA[AnyB])
                .Where<INode, INode>(z => z.A.Type == z.B.Type)
                .Mod(z => z.A.Replace(z.B.Node));
        }
    }
}
