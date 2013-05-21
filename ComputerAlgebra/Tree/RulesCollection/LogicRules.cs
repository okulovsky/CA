// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using AIRLab.CA.Resolution;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;
using AIRLab.GeneticAlgorithms;

namespace AIRLab.CA.RulesCollection
{
    public partial class LogicRules : SelectClauseWriter
    {
        private static readonly Random Rnd = new Random();

        public static IEnumerable<Rule> Get()
        {
            yield return Rule
                .New("Intro &&", StdTags.Inductive, StdTags.Logic, StdTags.SafeBlowing)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(new Logic.And(z.A.Node, Constant.Bool(true))));

            yield return Rule
                .New("Intro ||", StdTags.Inductive, StdTags.Logic, StdTags.SafeBlowing)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(new Logic.Or(z.A.Node, Constant.Bool(true))));

            yield return Rule
                .New("&&0", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Logic.And, Constant<bool>, INode>(z => !z.B.Value)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("||1", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Logic.Or, Constant<bool>, INode>(z => z.B.Value)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("&&1", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Logic.And, Constant<bool>, INode>(z => z.B.Value)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("||0", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Logic.Or, Constant<bool>, INode>(z => !z.B.Value)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("!!", StdTags.Deductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(AnyA[B[C]])
                .Where<Logic.Not, Logic.Not, INode>()
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("x V x", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(A[ChildB, ChildC])
                .Where<Logic.Or, INode, INode>(z => UnificationService.IsSame(z.B, z.C, true))
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("!x V x", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection, StdTags.Simplification)
                .Select(A[ChildB[ChildC], ChildD])
                .Where<Logic.Or, Logic.Not, INode, INode>(z => UnificationService.IsSame(z.C, z.D, true))
                .Mod(z => z.A.Replace(Constant.Bool(true)));

            yield return Rule
                .New("Intro !", StdTags.Inductive, StdTags.Logic, StdTags.UnsafeBlowing)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(new Logic.Not(z.A.Node)));

            yield return Rule
                .New("Intro B", StdTags.Tunning, StdTags.Logic)
                .Select(AnyA)
                .Where<INode<bool>>()
                .Mod(z => z.A.Replace(Constant.Bool(Rnd.RandomBool())));
        }
    }
}