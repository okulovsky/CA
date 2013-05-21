// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;
using AIRLab.GeneticAlgorithms;

namespace AIRLab.CA.RulesCollection
{
    public class AlgebraicRules : SelectClauseWriter
    {
        public static int RandomMin;
        public static int RandomMax;

        private static readonly Random Rnd = new Random();

        public static IEnumerable<Rule> Get()
        {
            yield return Rule
                .New("*0", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Arithmetic.Product<double>, Constant<double>, INode>(z => z.B.Value == 0)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("*1", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Arithmetic.Product<double>, Constant<double>, INode>(z => z.B.Value == 1)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("+0", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[ChildB, ChildC])
                .Where<Arithmetic.Plus<double>, Constant<double>, INode>(z => z.B.Value == 0)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("-0", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[C, B])
                .Where<Arithmetic.Minus<double>, Constant<double>, INode>(z => z.B.Value == 0)
                .Mod(z => z.A.Replace(z.C.Node));

            yield return Rule
                .New("/1", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Divide<double>, INode, Constant<double>>(z => z.C.Value == 1)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("0/", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Divide<double>, Constant<double>, INode>(z => z.B.Value == 0)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("0^", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Pow<double>, Constant<double>, INode>(z => z.B.Value == 0)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("^1", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Pow<double>, INode, Constant<double>>(z => z.C.Value == 1)
                .Mod(z => z.A.Replace(z.B.Node));

            yield return Rule
                .New("^0", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Pow<double>, INode, Constant<double>>(z => z.C.Value == 0)
                .Mod(z => z.A.Replace(Constant.Double(1)));

            yield return Rule
                .New("C+C", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Plus<double>, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(z.B.Node.Value + z.C.Node.Value)));

            yield return Rule
                .New("C*C", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Product<double>, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(z.B.Node.Value * z.C.Node.Value)));

            yield return Rule
                .New("C-C", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Minus<double>, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(z.B.Node.Value - z.C.Node.Value)));

            yield return Rule
                .New("C^C", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Pow<double>, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(Math.Pow(z.B.Node.Value, z.C.Node.Value))));

            yield return Rule
                .New("C/C", StdTags.SafeResection, StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[B, C])
                .Where<Arithmetic.Divide<double>, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(z.B.Node.Value / z.C.Node.Value)));

            yield return Rule
                .New("Intro +", StdTags.Inductive, StdTags.Algebraic, StdTags.SafeBlowing)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(z.A.Node, Constant.Double(0))));

            yield return Rule
                .New("Intro *", StdTags.Inductive, StdTags.Algebraic, StdTags.SafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Product<double>(z.A.Node, Constant.Double(1))));

            yield return Rule
                .New("Intro -", StdTags.Inductive, StdTags.Algebraic, StdTags.SafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Minus<double>(z.A.Node, Constant.Double(0))));

            yield return Rule
                .New("Intro /", StdTags.Inductive, StdTags.Algebraic, StdTags.SafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Divide<double>(z.A.Node, Constant.Double(1))));

            yield return Rule
                .New("Intro ^", StdTags.Inductive, StdTags.Algebraic, StdTags.SafeBlowing)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Pow<double>(z.A.Node, Constant.Double(1))));

//            yield return Rule
//                .New("SinC", StdTags.SafeResection, StdTags.Trigonometric, StdTags.Algebraic)
//                .Select(AnyA[B])
//                .Where<Arithmetic.Sin, Constant<double>>()
//                .Mod(z => z.A.Replace(Constant.Double(Math.Sin(z.B.Node.Value))));
//
//            yield return Rule
//                .New("CosC", StdTags.SafeResection, StdTags.Trigonometric, StdTags.Algebraic)
//                .Select(AnyA[B])
//                .Where<Arithmetic.Sin, Constant<double>>()
//                .Mod(z => z.A.Replace(Constant.Double(Math.Cos(z.B.Node.Value))));
//
//            yield return Rule
//                .New("TanC", StdTags.SafeResection, StdTags.Trigonometric, StdTags.Algebraic)
//                .Select(AnyA[B])
//                .Where<Arithmetic.Sin, Constant<double>>()
//                .Mod(z => z.A.Replace(Constant.Double(Math.Tan(z.B.Node.Value))));

            yield return Rule
                .New("Intro +", StdTags.Inductive, StdTags.Algebraic, StdTags.UnsafeBlowing)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(z.A.Node, Constant.Double(Rnd.RandomInt(RandomMin, RandomMax)))));

            yield return Rule
                .New("Intro *", StdTags.Inductive, StdTags.Algebraic, StdTags.UnsafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Product<double>(z.A.Node, Constant.Double(Rnd.RandomInt(RandomMin, RandomMax)))));

            yield return Rule
                .New("Intro -", StdTags.Inductive, StdTags.Algebraic, StdTags.UnsafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Minus<double>(z.A.Node, Constant.Double(Rnd.RandomInt(RandomMin, RandomMax)))));

            yield return Rule
                .New("Intro /", StdTags.Inductive, StdTags.Algebraic, StdTags.UnsafeBlowing)
                .Select(AnyA).Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Divide<double>(z.A.Node, Constant.Double(Rnd.RandomInt(RandomMin, RandomMax)))));

            yield return Rule
                .New("Intro ^", StdTags.Inductive, StdTags.Algebraic, StdTags.UnsafeBlowing)
                .Select(AnyA)
                .Where<INode<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Pow<double>(z.A.Node, Constant.Double(Rnd.RandomInt(RandomMin, RandomMax)))));

//            yield return Rule
//                .New("Intro Sin", StdTags.Inductive, StdTags.Trigonometric, StdTags.UnsafeBlowing, StdTags.Algebraic)
//                .Select(AnyA)
//                .Where<INode<double>>()
//                .Mod(z => z.A.Replace(new Arithmetic.Sin(z.A.Node)));
//
//            yield return Rule
//                .New("Intro Cos", StdTags.Inductive, StdTags.Trigonometric, StdTags.UnsafeBlowing, StdTags.Algebraic)
//                .Select(AnyA)
//                .Where<INode<double>>()
//                .Mod(z => z.A.Replace(new Arithmetic.Cos(z.A.Node)));
//
//            yield return Rule
//                .New("Intro Tan", StdTags.Inductive, StdTags.Trigonometric, StdTags.UnsafeBlowing, StdTags.Algebraic)
//                .Select(AnyA)
//                .Where<INode<double>>()
//                .Mod(z => z.A.Replace(new Arithmetic.Tan(z.A.Node)));

            yield return Rule
                .New("Tune C", StdTags.Tunning, StdTags.Algebraic)
                .Select(AnyA)
                .Where<Constant<double>>()
                .Mod(z => z.A.Replace(Constant.Double(Rnd.RandomInt(RandomMin, RandomMax))));
        }
    }
}
