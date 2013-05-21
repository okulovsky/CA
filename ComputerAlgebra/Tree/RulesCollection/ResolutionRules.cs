using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIRLab.CA
{
    public partial class ResolutionRules : SelectClauseWriter
    {
        public static IEnumerable<Rule> Get()
        {
            yield return Rule
                .New("Resolve", StdTags.Inductive, StdTags.Logic, StdTags.SafeResection)
                .Select(AnyA[ChildB[ChildC], ChildD[ChildE]])
                .Where<Logic.Resolve, Logic.MultipleOr, PredicateNode, Logic.MultipleOr, Logic.Not>(z => z.E.Children[0] is PredicateNode &&
                                                                            UnificationService.CanUnificate(z.C, (PredicateNode)z.E.Children[0]))
                .Mod(z => Modificator(z));
        }

        /// <summary>
        /// Пользуемся правилом резолюции: A V B, C V !B |- A V C. 
        /// </summary>
        /// <param name="z"></param>
        private static void Modificator(TypizedDecorArray<Logic.Resolve, Logic.MultipleOr, PredicateNode, Logic.MultipleOr, Logic.Not> z)
        {
            var rules = UnificationService.GetUnificationRules(z.C.Node, (PredicateNode)z.E.Node.Children[0]);
            UnificationService.Unificate(z.B.Node, rules);
            UnificationService.Unificate(z.D.Node, rules);
            var bdChildren = z.B.Node.Children.ToList();
            bdChildren.AddRange(z.D.Node.Children.ToList());
            bdChildren.Remove(z.C.Node);
            bdChildren.Remove(z.E.Node);
            z.A.Replace(new Logic.MultipleOr(bdChildren.ToArray()));
        }
    }
}
