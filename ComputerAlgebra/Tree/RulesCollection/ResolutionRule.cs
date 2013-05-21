// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Linq;
using AIRLab.CA.Resolution;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.RulesCollection
{
    public partial class ResolutionRule : SelectClauseWriter
    {
        public static Rule Get()
        {
            return Rule
                .New("Resolve", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection)
                .Select(A[ChildB], C[ChildD])
                .Where<Logic.MultipleOr, SkolemPredicateNode, Logic.MultipleOr, SkolemPredicateNode>(z => UnificationService.CanUnificate(z.B, z.D)
                                                                                                             && (z.B.IsNegate || z.D.IsNegate))
                .Mod(Modificator);
        }

        /// <summary>
        /// Пользуемся правилом резолюции: A V B, C V !B |- A V C. 
        /// </summary>
        /// <param name="z"></param>
        private static void Modificator(TypizedDecorArray<Logic.MultipleOr, SkolemPredicateNode, Logic.MultipleOr, SkolemPredicateNode> z)
        {
            var rules = UnificationService.GetUnificationRules(z.B.Node, z.D.Node);
            UnificationService.Unificate(z.A.Node, rules);
            UnificationService.Unificate(z.C.Node, rules);
            var aChildren = z.A.Node.Children.ToList();
            var cChildren = z.C.Node.Children.ToList();
            aChildren.Remove(z.B.Node);
            cChildren.Remove(z.D.Node);
            z.A.Replace(new Logic.MultipleOr(aChildren.ToArray()));
            z.C.Replace(new Logic.MultipleOr(cChildren.ToArray()));
        }
    }
}
