// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

namespace AIRLab.CA.Rules
{
    using System;
    using Tree;
    using Tools;
    public class TypizedNodeArray<T0> : WhereOutput where T0 : INode
    {
        public T0 A { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0>(c);
        }
    }
    public class TypizedDecorArray<T0> : ModInput where T0 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0> Where<T0>() where T0 : INode { return Where<T0>(z => true); }
        public SelectWhereRule<T0> Where<T0>(Func<TypizedNodeArray<T0>, bool> where) where T0 : INode
        {
            return new SelectWhereRule<T0>(this, sel =>
            {
                var tna = Typize<T0>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0> Typize<T0>(INode[] array) where T0 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            return res;
        }
    }
    public class SelectWhereRule<T0> : SelectWhereRule where T0 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0>)z));
        }
    }

    public class TypizedNodeArray<T0, T1> : WhereOutput
        where T0 : INode
        where T1 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1>(c);
        }
    }
    public class TypizedDecorArray<T0, T1> : ModInput
        where T0 : INode
        where T1 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1> Where<T0, T1>()
            where T0 : INode
            where T1 : INode { return Where<T0, T1>(z => true); }
        public SelectWhereRule<T0, T1> Where<T0, T1>(Func<TypizedNodeArray<T0, T1>, bool> where)
            where T0 : INode
            where T1 : INode
        {
            return new SelectWhereRule<T0, T1>(this, sel =>
            {
                var tna = Typize<T0, T1>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1> Typize<T0, T1>(INode[] array)
            where T0 : INode
            where T1 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1> : SelectWhereRule
        where T0 : INode
        where T1 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2> Where<T0, T1, T2>()
            where T0 : INode
            where T1 : INode
            where T2 : INode { return Where<T0, T1, T2>(z => true); }
        public SelectWhereRule<T0, T1, T2> Where<T0, T1, T2>(Func<TypizedNodeArray<T0, T1, T2>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
        {
            return new SelectWhereRule<T0, T1, T2>(this, sel =>
            {
                var tna = Typize<T0, T1, T2>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2> Typize<T0, T1, T2>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode { return Where<T0, T1, T2, T3>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>(Func<TypizedNodeArray<T0, T1, T2, T3>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3> Typize<T0, T1, T2, T3>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode { return Where<T0, T1, T2, T3, T4>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>(Func<TypizedNodeArray<T0, T1, T2, T3, T4>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4> Typize<T0, T1, T2, T3, T4>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        public T5 F { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; } public NodeDecorator<T5> F { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode { return Where<T0, T1, T2, T3, T4, T5>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4, T5> Typize<T0, T1, T2, T3, T4, T5>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4, T5>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            if (!(array[5] is T5)) return null;
            res.F = (T5)array[5];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        public T5 F { get; set; }
        public T6 G { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; } public NodeDecorator<T5> F { get; private set; } public NodeDecorator<T6> G { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
            G = new NodeDecorator<T6>(this, (T6)c[6]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode { return Where<T0, T1, T2, T3, T4, T5, T6>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6> Typize<T0, T1, T2, T3, T4, T5, T6>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            if (!(array[5] is T5)) return null;
            res.F = (T5)array[5];
            if (!(array[6] is T6)) return null;
            res.G = (T6)array[6];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7> : WhereOutput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
        where T7 : INode
    {
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        public T5 F { get; set; }
        public T6 G { get; set; }
        public T7 H { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
        where T7 : INode
    {
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; } public NodeDecorator<T5> F { get; private set; } public NodeDecorator<T6> G { get; private set; } public NodeDecorator<T7> H { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
            G = new NodeDecorator<T6>(this, (T6)c[6]);
            H = new NodeDecorator<T7>(this, (T7)c[7]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> Where<T0, T1, T2, T3, T4, T5, T6, T7>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode { return Where<T0, T1, T2, T3, T4, T5, T6, T7>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> Where<T0, T1, T2, T3, T4, T5, T6, T7>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7> Typize<T0, T1, T2, T3, T4, T5, T6, T7>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode
        {
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            if (!(array[5] is T5)) return null;
            res.F = (T5)array[5];
            if (!(array[6] is T6)) return null;
            res.G = (T6)array[6];
            if (!(array[7] is T7)) return null;
            res.H = (T7)array[7];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
        where T7 : INode
    {
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> : WhereOutput
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
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        public T5 F { get; set; }
        public T6 G { get; set; }
        public T7 H { get; set; }
        public T8 I { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> : ModInput
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
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; } public NodeDecorator<T5> F { get; private set; } public NodeDecorator<T6> G { get; private set; } public NodeDecorator<T7> H { get; private set; } public NodeDecorator<T8> I { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
            G = new NodeDecorator<T6>(this, (T6)c[6]);
            H = new NodeDecorator<T7>(this, (T7)c[7]);
            I = new NodeDecorator<T8>(this, (T8)c[8]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode
            where T8 : INode { return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8>(INode[] array)
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
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            if (!(array[5] is T5)) return null;
            res.F = (T5)array[5];
            if (!(array[6] is T6)) return null;
            res.G = (T6)array[6];
            if (!(array[7] is T7)) return null;
            res.H = (T7)array[7];
            if (!(array[8] is T8)) return null;
            res.I = (T8)array[8];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> : SelectWhereRule
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
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>)z));
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : WhereOutput
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
        public T0 A { get; set; }
        public T1 B { get; set; }
        public T2 C { get; set; }
        public T3 D { get; set; }
        public T4 E { get; set; }
        public T5 F { get; set; }
        public T6 G { get; set; }
        public T7 H { get; set; }
        public T8 I { get; set; }
        public T9 J { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(c);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ModInput
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
        public NodeDecorator<T0> A { get; private set; } public NodeDecorator<T1> B { get; private set; } public NodeDecorator<T2> C { get; private set; } public NodeDecorator<T3> D { get; private set; } public NodeDecorator<T4> E { get; private set; } public NodeDecorator<T5> F { get; private set; } public NodeDecorator<T6> G { get; private set; } public NodeDecorator<T7> H { get; private set; } public NodeDecorator<T8> I { get; private set; } public NodeDecorator<T9> J { get; private set; }
        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
            G = new NodeDecorator<T6>(this, (T6)c[6]);
            H = new NodeDecorator<T7>(this, (T7)c[7]);
            I = new NodeDecorator<T8>(this, (T8)c[8]);
            J = new NodeDecorator<T9>(this, (T9)c[9]);
        }
    }
    partial class SelectRule
    {
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode
            where T8 : INode
            where T9 : INode { return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(z => true); }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, sel =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(sel.SelectedNodes);
                if (tna == null) return null;
                tna.SelectResult = sel;
                return where(tna) ? tna : null;
            });
        }

        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(INode[] array)
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
            if (array == null) return null; var res = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            if (!(array[0] is T0)) return null;
            res.A = (T0)array[0];
            if (!(array[1] is T1)) return null;
            res.B = (T1)array[1];
            if (!(array[2] is T2)) return null;
            res.C = (T2)array[2];
            if (!(array[3] is T3)) return null;
            res.D = (T3)array[3];
            if (!(array[4] is T4)) return null;
            res.E = (T4)array[4];
            if (!(array[5] is T5)) return null;
            res.F = (T5)array[5];
            if (!(array[6] is T6)) return null;
            res.G = (T6)array[6];
            if (!(array[7] is T7)) return null;
            res.H = (T7)array[7];
            if (!(array[8] is T8)) return null;
            res.I = (T8)array[8];
            if (!(array[9] is T9)) return null;
            res.J = (T9)array[9];
            return res;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : SelectWhereRule
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
        Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> where;
        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> where) : base(selectRule) { this.where = where; }
        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> replace)
        {
            return new Rule(this.SelectRule.NewRule.Name, this.SelectRule.NewRule.Tags, this.SelectRule.Selector, z => where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>)z));
        }
    }

    public class SelectClauseWriter
    {
        public static SelectClauseNode AnyA { get { return new SelectClauseNode(0, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildA { get { return new SelectClauseNode(0, LetterRecursionType.Children); } }
        public static SelectClauseNode A { get { return new SelectClauseNode(0, LetterRecursionType.No); } }
        public static SelectClauseNode AnyB { get { return new SelectClauseNode(1, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildB { get { return new SelectClauseNode(1, LetterRecursionType.Children); } }
        public static SelectClauseNode B { get { return new SelectClauseNode(1, LetterRecursionType.No); } }
        public static SelectClauseNode AnyC { get { return new SelectClauseNode(2, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildC { get { return new SelectClauseNode(2, LetterRecursionType.Children); } }
        public static SelectClauseNode C { get { return new SelectClauseNode(2, LetterRecursionType.No); } }
        public static SelectClauseNode AnyD { get { return new SelectClauseNode(3, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildD { get { return new SelectClauseNode(3, LetterRecursionType.Children); } }
        public static SelectClauseNode D { get { return new SelectClauseNode(3, LetterRecursionType.No); } }
        public static SelectClauseNode AnyE { get { return new SelectClauseNode(4, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildE { get { return new SelectClauseNode(4, LetterRecursionType.Children); } }
        public static SelectClauseNode E { get { return new SelectClauseNode(4, LetterRecursionType.No); } }
        public static SelectClauseNode AnyF { get { return new SelectClauseNode(5, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildF { get { return new SelectClauseNode(5, LetterRecursionType.Children); } }
        public static SelectClauseNode F { get { return new SelectClauseNode(5, LetterRecursionType.No); } }
        public static SelectClauseNode AnyG { get { return new SelectClauseNode(6, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildG { get { return new SelectClauseNode(6, LetterRecursionType.Children); } }
        public static SelectClauseNode G { get { return new SelectClauseNode(6, LetterRecursionType.No); } }
        public static SelectClauseNode AnyH { get { return new SelectClauseNode(7, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildH { get { return new SelectClauseNode(7, LetterRecursionType.Children); } }
        public static SelectClauseNode H { get { return new SelectClauseNode(7, LetterRecursionType.No); } }
        public static SelectClauseNode AnyI { get { return new SelectClauseNode(8, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildI { get { return new SelectClauseNode(8, LetterRecursionType.Children); } }
        public static SelectClauseNode I { get { return new SelectClauseNode(8, LetterRecursionType.No); } }
        public static SelectClauseNode AnyJ { get { return new SelectClauseNode(9, LetterRecursionType.Subtree); } }
        public static SelectClauseNode ChildJ { get { return new SelectClauseNode(9, LetterRecursionType.Children); } }
        public static SelectClauseNode J { get { return new SelectClauseNode(9, LetterRecursionType.No); } }
    }
    public class LogicExpressions
    {
        public static CABoolean K(params int[] args) { return new CABoolean(); }
        public static CABoolean L(params int[] args) { return new CABoolean(); }
        public static CABoolean M(params int[] args) { return new CABoolean(); }
        public static CABoolean N(params int[] args) { return new CABoolean(); }
        public static CABoolean O(params int[] args) { return new CABoolean(); }
        public static CABoolean P(params int[] args) { return new CABoolean(); }
        public static CABoolean Q(params int[] args) { return new CABoolean(); }
        public static CABoolean R(params int[] args) { return new CABoolean(); }
        public static CABoolean S(params int[] args) { return new CABoolean(); }
        public static int f(params int[] args) { return 1; }
        public static int g(params int[] args) { return 1; }
        public static int h(params int[] args) { return 1; }
        public static int i(params int[] args) { return 1; }
        public static int j(params int[] args) { return 1; }
        public static int k(params int[] args) { return 1; }
        public static int l(params int[] args) { return 1; }
        public static int m(params int[] args) { return 1; }
        public static int n(params int[] args) { return 1; }
        public const int a = 0;
        public const int b = 1;
        public const int c = 2;
        public const int d = 3;
        public const int e = 4;
    }
}