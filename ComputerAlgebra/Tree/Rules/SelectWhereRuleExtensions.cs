// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public static class SelectWhereRuleExtensions
    {
        public static Rule Mod<T0>(this ISelectWhereRule<T0> rule, Action<ITypizedDecorArray<T0>> replace)
            where T0 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0>)z));
        }

        public static Rule Mod<T0, T1>(this ISelectWhereRule<T0, T1> rule, Action<ITypizedDecorArray<T0, T1>> replace)
            where T0 : INode 
            where T1 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1>)z));
        }

        public static Rule Mod<T0, T1, T2>(this ISelectWhereRule<T0, T1, T2> rule, Action<ITypizedDecorArray<T0, T1, T2>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2>)z));
        }

        public static Rule Mod<T0, T1, T2, T3>(this ISelectWhereRule<T0, T1, T2, T3> rule, Action<ITypizedDecorArray<T0, T1, T2, T3>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4>(this ISelectWhereRule<T0, T1, T2, T3, T4> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
            where T8 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
            where T8 : INode 
            where T9 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
            where T8 : INode 
            where T9 : INode 
            where T10 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
            where T8 : INode 
            where T9 : INode 
            where T10 : INode 
            where T11 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)z));
        }

        public static Rule Mod<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> rule, Action<ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> replace)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
            where T8 : INode 
            where T9 : INode 
            where T10 : INode 
            where T11 : INode 
            where T12 : INode 
        {
            return new Rule(rule.SelectRule.NewRule.Name, rule.SelectRule.NewRule.Tags, rule.SelectRule.Selector, z => rule.Invoke(z), z => replace((ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)z));
        }

    }
}
