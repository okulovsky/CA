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
    public partial class ComparisonRules : SelectClauseWriter
    {
        public static IEnumerable<Rule> Get()
        {
            yield return Rule
                .New("Intro <", StdTags.Inductive, StdTags.Comparison, StdTags.UnsafeBlowing)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(new Comparison.LessThan(Constant.Double(0), Constant.Double(0))));

            yield return Rule
                .New("Intro =", StdTags.Inductive, StdTags.Comparison, StdTags.UnsafeBlowing)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(new Comparison.Equal(Constant.Double(0), Constant.Double(0))));
        }
    }
}