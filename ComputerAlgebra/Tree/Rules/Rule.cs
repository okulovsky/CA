// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class Rule : IRule
    {
        readonly IComplexSelector _selector;
        readonly Func<ISelectOutput, IWhereOutput> _where;
        readonly Action<IModInput> _apply;

        public string Name { get; private set; }
        public IReadOnlyCollection<string> Tags { get; private set; }

        public Rule(string name, IEnumerable<string> tags, IComplexSelector selector, Func<ISelectOutput, IWhereOutput> where, Action<IModInput> apply)
        {
            _selector = selector;
            _where = where;
            _apply = apply;
            Name = name;
            Tags = new ReadOnlyCollection<string>(tags.ToArray());
        }

        public IEnumerable<ISelectOutput> Select(params INode[] roots)
        {
            return _selector.Select(roots);
        }

        public IEnumerable<IWhereOutput> SelectWhere(params INode[] roots)
        {
            return _selector.Select(roots)
                           .Select(e => _where(e))
                           .Where(res => res != null);
        }

        public INode[] Apply(IWhereOutput instance)
        {
            var safe = instance.MakeSafe();
            _apply(safe);
            return safe.Roots.Any(e => !e.TestRoot()) 
                ? null 
                : safe.Roots;
        }

        public static INewRule New(string name, params string[] tags)
        {
            return new NewRule(name, tags);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
