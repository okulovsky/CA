// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Rules;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Tools
{
    public class Simplifier
    {
        public static INode Simplify(INode node, List<Rule> rules)
        {
            var current = node;
            string firstRep;
            do
            {
                firstRep = current.ToString();
                foreach (var r in rules)
                {
                    var instances = r.SelectWhere(current);
                    if (instances == null || instances.Count() == 0) continue;
                    foreach (var ins in instances)
                    {
                        var roots = r.Apply(ins);
                        if (roots == null || roots.Count()==0 || roots[0]==null) continue;
                        current = roots[0];
                        break;
                    }
                }
            } while (firstRep != current.ToString());
            return current;
        }
    }
}
