// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using AIRLab.CA.Resolution;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Operators.Logic;
using AIRLab.CA.Tree.Rules;

namespace AIRLab.CA.Tree.RulesCollection
{
    public class LogicRules : SelectClauseWriter
    {
        public static IEnumerable<Rule> Get()
        {
            yield return Rule
                .New("&&0", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<And, Constant<bool>, INode>(z => !z.B.Value)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("||1", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Or, Constant<bool>, INode>(z => z.B.Value)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("&&1", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<And, Constant<bool>, INode>(z => z.B.Value)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("||0", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Or, Constant<bool>, INode>(z => !z.B.Value)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("!!", StdTags.Deductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[B[C]])
                .Where<Not, Not, INode>()
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("x V x", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(A[ChildB, ChildC])
                .Where<Or, INode, INode>(z => UnificationService.IsSame(z.B, z.C, true))
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("!x V x", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(A[ChildB[ChildC], ChildD])
                .Where<Or, Not, INode, INode>(z => UnificationService.IsSame(z.C, z.D, true))
                .Mod(z => z.A.Replace(Constant.Bool(true)));
        }
    }
}