// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Rules
{
   
    public class ComplexSelector
    {
        readonly List<BasicSelector> _selectors;
        public ComplexSelector(params SelectClauseNode[] selectClauses)
        {
            _selectors = selectClauses.Select(z => new BasicSelector(z)).ToList();
        }

        static SelectOutput Assemble(INode[] roots, INode[][] result)
        {
            var n = new INode[result.Select(z => z.Length).Max()];
            foreach (var t in result)
            {
                for (var j = 0; j < t.Length; j++)
                {
                    if (t[j] != null)
                    {
                        n[j] = t[j];
                    }
                }
            }
            return new SelectOutput(n, roots);
        }

        public IEnumerable<SelectOutput> Select(params INode[] roots)
        {
            if (roots.Length != _selectors.Count)
            {
                throw new Exception("Selector was created for " + _selectors.Count() + " nodes, but was given " +
                                    roots.Length + " node to process");
            }

            if (_selectors.Count == 1)
            {
                foreach (var e in _selectors[0].Select(roots[0]))
                    yield return new SelectOutput(e,roots);
                yield break;
            }
            
            var results = new INode[roots.Length][];
            var enums = new IEnumerator<INode[]>[roots.Length];
            var current = 0;
            enums[0] = _selectors[0].Select(roots[0]).GetEnumerator();
            
            while (true)
            {
                var resp = enums[current].MoveNext();
                if (!resp)
                {
                    if (current == 0) yield break;
                    current--;
                    continue;
                }
                results[current]=enums[current].Current;
                current++;
                if (current == roots.Length)
                {
                    yield return Assemble(roots,results);
                    current--;
                }
                else
                {
                    enums[current] = _selectors[current].Select(roots[current]).GetEnumerator();
                }
            }
        }
    }
}
