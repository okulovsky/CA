// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{

    public class SelectWhereRule : ISelectWhereRule
    {
        public ISelectRule SelectRule { get; private set; }
        public SelectWhereRule(ISelectRule selectRule)
        {
            SelectRule = selectRule;
        }
    }

    public class SelectWhereRule<T0> : SelectWhereRule, ISelectWhereRule<T0>
        where T0 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1> : SelectWhereRule, ISelectWhereRule<T0, T1>
        where T0 : INode 
        where T1 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2> : SelectWhereRule, ISelectWhereRule<T0, T1, T2>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
        where T7 : INode 
    {
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : SelectWhereRule, ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
        public Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> Invoke { get; private set; }

        public SelectWhereRule(ISelectRule selectRule, Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> where) : base(selectRule)
        {
            Invoke = where;
        }
    }
}
