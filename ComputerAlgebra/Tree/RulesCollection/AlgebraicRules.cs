// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.RulesCollection
{
    public class AlgebraicRules : SelectClauseWriter
    {
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
                .New("(x+C)+C", StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Arithmetic.Plus, Arithmetic.Plus, INode, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(z.C.Node, Constant.Double(z.D.Node.Value + z.E.Node.Value))));

            yield return Rule
                .New("(x-C)+C", StdTags.Algebraic, StdTags.Simplification)
                .Select(AnyA[ChildB[C, D], ChildE])
                .Where<Arithmetic.Plus, Arithmetic.Minus, INode, Constant<double>, Constant<double>>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(z.C.Node, Constant.Double(z.E.Node.Value - z.D.Node.Value))));
        }
    }
}
