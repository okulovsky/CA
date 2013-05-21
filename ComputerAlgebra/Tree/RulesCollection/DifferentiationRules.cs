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
    public partial class DifferentiationRules : SelectClauseWriter
    {
        public static IEnumerable<Rule> Get()
        {
            yield return Rule
               .New("d(-U)/dx", StdTags.Differentiation, StdTags.Algebraic)
               .Select(AnyA[ChildB[ChildC], ChildD])
               .Where<Differentiation.Dif<double>, Arithmetic.Negate<double>, INode, VariableNode>()
               .Mod(z => z.A.Replace(new Arithmetic.Negate<double>(new Differentiation.Dif<double>(z.C.Node, z.D.Node))));

            yield return Rule
                .New("d(U+V)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Differentiation.Dif<double>, Arithmetic.Plus<double>, INode, INode, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(new Differentiation.Dif<double>(z.C.Node, z.E.Node), new Differentiation.Dif<double>(z.D.Node, (VariableNode)z.E.Node.Clone()))));

            yield return Rule
                .New("d(U-V)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Differentiation.Dif<double>, Arithmetic.Minus<double>, INode, INode, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Minus<double>(new Differentiation.Dif<double>(z.C.Node, z.E.Node), new Differentiation.Dif<double>(z.D.Node, (VariableNode)z.E.Node.Clone()))));

            yield return Rule
                .New("d(U*V)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Differentiation.Dif<double>, Arithmetic.Product<double>, INode, INode, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Plus<double>(
                    new Arithmetic.Product<double>(new Differentiation.Dif<double>(z.C.Node, z.E.Node), z.D.Node),
                    new Arithmetic.Product<double>(new Differentiation.Dif<double>((INode)z.D.Node.Clone(), (VariableNode)z.E.Node.Clone()), (INode)z.C.Node.Clone()))));

            yield return Rule
                .New("d(U/V)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Differentiation.Dif<double>, Arithmetic.Divide<double>, INode, INode, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Divide<double>(
                        new Arithmetic.Minus<double>(
                            new Arithmetic.Product<double>(
                                new Differentiation.Dif<double>(z.C.Node, z.E.Node), z.D.Node),
                            new Arithmetic.Product<double>(
                                new Differentiation.Dif<double>((INode)z.D.Node.Clone(), (VariableNode)z.E.Node.Clone()), (INode)z.C.Node.Clone())),
                        new Arithmetic.Pow<double>((INode)z.D.Node.Clone(), Constant.Double(2.0)))));

            yield return Rule
                .New("d(U^c)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
                .Where<Differentiation.Dif<double>, Arithmetic.Pow<double>, INode, Constant<double>, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Product<double>(
                    Constant.Double(z.D.Node.Value),
                    new Arithmetic.Pow<double>(z.C.Node, Constant.Double(z.D.Node.Value - 1)))));

            yield return Rule
               .New("d(U^V)/dx", StdTags.Differentiation, StdTags.Algebraic)
               .Select(AnyA[ChildB[ChildC, ChildD], ChildE])
               .Where<Differentiation.Dif<double>, Arithmetic.Pow<double>, INode, INode, VariableNode>()
               .Mod(z => z.A.Replace(new Arithmetic.Product<double>(
                   new Arithmetic.Pow<double>(z.C.Node, z.D.Node),
                   new Arithmetic.Plus<double>(
                       new Arithmetic.Product<double>(new Differentiation.Dif<double>((INode)z.D.Node.Clone(), z.E.Node), new Arithmetic.Ln((INode)z.C.Node.Clone())),
                       new Arithmetic.Divide<double>(
                           new Arithmetic.Product<double>((INode)z.D.Node.Clone(), new Differentiation.Dif<double>((INode)z.C.Node.Clone(), (VariableNode)z.E.Node.Clone())),
                           (INode)z.C.Node.Clone())))));
            
            yield return Rule
                .New("d(lnU)/dx", StdTags.Differentiation, StdTags.Algebraic)
                .Select(AnyA[ChildB[ChildC], ChildD])
                .Where<Differentiation.Dif<double>, Arithmetic.Ln, INode, VariableNode>()
                .Mod(z => z.A.Replace(new Arithmetic.Divide<double>(Constant.Double(1), (INode)z.C.Node.Clone())));
             
            yield return Rule
                .New("dx/dx", StdTags.Differentiation, StdTags.Deductive, StdTags.Algebraic)
                .Select(AnyA[ChildB, ChildC])
                .Where<Differentiation.Dif<double>, VariableNode, VariableNode>(z => z.B.Index == z.C.Index)
                .Mod(z => z.A.Replace(Constant.Double(1.0)));

            yield return Rule
                .New("dy/dx", StdTags.Differentiation, StdTags.Deductive, StdTags.Algebraic)
                .Select(AnyA[ChildB, ChildC])
                .Where<Differentiation.Dif<double>, VariableNode, VariableNode>(z => z.B.Index != z.C.Index)
                .Mod(z => z.A.Replace(Constant.Double(0.0)));

            yield return Rule
                .New("dc/dx", StdTags.Differentiation, StdTags.Deductive, StdTags.Algebraic)
                .Select(AnyA[ChildB, ChildC])
                .Where<Differentiation.Dif<double>, Constant<double>, VariableNode>()
                .Mod(z => z.A.Replace(Constant.Double(0.0)));
        }
    }
}
