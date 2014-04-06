// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System.Collections.Generic;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public class TypizedNodeArray<T0> : WhereOutput, ITypizedNodeArray<T0>
        where T0 : INode 
    {
        public T0 A { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0>(c);
        }
    }

    public class TypizedNodeArray<T0, T1> : WhereOutput, ITypizedNodeArray<T0, T1>
        where T0 : INode 
        where T1 : INode 
    {
        public T0 A { get; set; } 
        public T1 B { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2> : WhereOutput, ITypizedNodeArray<T0, T1, T2>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        public T0 A { get; set; } 
        public T1 B { get; set; } 
        public T2 C { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        public T0 A { get; set; } 
        public T1 B { get; set; } 
        public T2 C { get; set; } 
        public T3 D { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
        public T10 K { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
        public T10 K { get; set; } 
        public T11 L { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(c);
        }
    }

    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : WhereOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
        public T10 K { get; set; } 
        public T11 L { get; set; } 
        public T12 M { get; set; } 

        override protected IModInput MakeSafeRuleInstance(IList<INode> c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(c);
        }
    }

}