// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Tools;

namespace AIRLab.CA.Tree.Rules
{
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedNodeArray<T0> : WhereOutput where T0 : INode
    {
        public T0 A { get; set; }
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0>(c);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : WhereOutput
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
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(c);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : WhereOutput
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
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(c);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : WhereOutput
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
        override protected ModInput MakeSafeRuleInstance(INode[] c)
        {
            return new TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(c);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0> : ModInput where T0 : INode
    {
        public NodeDecorator<T0> A { get; private set; }

        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1> : ModInput
        where T0 : INode
        where T1 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }

        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }

        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }

        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }

        public TypizedDecorArray(INode[] c)
        {
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }

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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6> : ModInput
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
    {
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }

        public TypizedDecorArray(IList<INode> c)
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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }

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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }
        public NodeDecorator<T8> I { get; private set; }

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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }
        public NodeDecorator<T8> I { get; private set; }
        public NodeDecorator<T9> J { get; private set; }

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
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ModInput
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }
        public NodeDecorator<T8> I { get; private set; }
        public NodeDecorator<T9> J { get; private set; }
        public NodeDecorator<T10> K { get; private set; }

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
            K = new NodeDecorator<T10>(this, (T10)c[10]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ModInput
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }
        public NodeDecorator<T8> I { get; private set; }
        public NodeDecorator<T9> J { get; private set; }
        public NodeDecorator<T10> K { get; private set; }
        public NodeDecorator<T11> L { get; private set; }

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
            K = new NodeDecorator<T10>(this, (T10)c[10]);
            L = new NodeDecorator<T11>(this, (T11)c[11]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ModInput
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
        public NodeDecorator<T0> A { get; private set; }
        public NodeDecorator<T1> B { get; private set; }
        public NodeDecorator<T2> C { get; private set; }
        public NodeDecorator<T3> D { get; private set; }
        public NodeDecorator<T4> E { get; private set; }
        public NodeDecorator<T5> F { get; private set; }
        public NodeDecorator<T6> G { get; private set; }
        public NodeDecorator<T7> H { get; private set; }
        public NodeDecorator<T8> I { get; private set; }
        public NodeDecorator<T9> J { get; private set; }
        public NodeDecorator<T10> K { get; private set; }
        public NodeDecorator<T11> L { get; private set; }
        public NodeDecorator<T12> M { get; private set; }

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
            K = new NodeDecorator<T10>(this, (T10)c[10]);
            L = new NodeDecorator<T11>(this, (T11)c[11]);
            M = new NodeDecorator<T12>(this, (T12)c[12]);
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectRule
    {
        public ComplexSelector Selector;
        public NewRule NewRule;
        public SelectRule(NewRule newRule, ComplexSelector selector)
        {
            Selector = selector;
            NewRule = newRule;
        }
        public SelectWhereRule<T0> Where<T0>() where T0 : INode
        {
            return Where<T0>(z => true);
        }

        public SelectWhereRule<T0> Where<T0>(Func<TypizedNodeArray<T0>, bool> where) where T0 : INode
        {
            return new SelectWhereRule<T0>(this, selector =>
            {
                var tna = Typize<T0>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0> Typize<T0>(INode[] array) where T0 : INode
        {
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1> Where<T0, T1>()
            where T0 : INode
            where T1 : INode
        {
            return Where<T0, T1>(z => true);
        }

        public SelectWhereRule<T0, T1> Where<T0, T1>(Func<TypizedNodeArray<T0, T1>, bool> where)
            where T0 : INode
            where T1 : INode
        {
            return new SelectWhereRule<T0, T1>(this, selector =>
            {
                var tna = Typize<T0, T1>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1> Typize<T0, T1>(INode[] array)
            where T0 : INode
            where T1 : INode
        {
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2> Where<T0, T1, T2>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
        {
            return Where<T0, T1, T2>(z => true);
        }

        public SelectWhereRule<T0, T1, T2> Where<T0, T1, T2>(Func<TypizedNodeArray<T0, T1, T2>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
        {
            return new SelectWhereRule<T0, T1, T2>(this, selector =>
            {
                var tna = Typize<T0, T1, T2>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1, T2> Typize<T0, T1, T2>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
        {
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
        {
            return Where<T0, T1, T2, T3>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>(Func<TypizedNodeArray<T0, T1, T2, T3>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1, T2, T3> Typize<T0, T1, T2, T3>(INode[] array)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
        {
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
        {
            return Where<T0, T1, T2, T3, T4>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>(Func<TypizedNodeArray<T0, T1, T2, T3, T4>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
        {
            return Where<T0, T1, T2, T3, T4, T5>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
        {
            return Where<T0, T1, T2, T3, T4, T5, T6>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>, bool> where)
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> Where<T0, T1, T2, T3, T4, T5, T6, T7>()
            where T0 : INode
            where T1 : INode
            where T2 : INode
            where T3 : INode
            where T4 : INode
            where T5 : INode
            where T6 : INode
            where T7 : INode
        {
            return Where<T0, T1, T2, T3, T4, T5, T6, T7>(z => true);
        }

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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>()
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
            return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(z => true);
        }

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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
                return null;
            typizedNodeArray.I = (T8)array[8];

            return typizedNodeArray;
        }
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
            where T9 : INode
        {
            return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(z => true);
        }

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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
                return null;
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
                return null;
            typizedNodeArray.J = (T9)array[9];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
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
            return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(INode[] array)
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
                return null;
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
                return null;
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
                return null;
            typizedNodeArray.K = (T10)array[10];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
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
            return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(INode[] array)
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
                return null;
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
                return null;
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
                return null;
            typizedNodeArray.K = (T10)array[10];

            if (!(array[11] is T11))
                return null;
            typizedNodeArray.L = (T11)array[11];

            return typizedNodeArray;
        }
        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
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
            return Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(z => true);
        }

        public SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(selector.SelectedNodes);
                if (tna == null)
                    return null;
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }
        TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(INode[] array)
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
            if (array == null)
                return null;
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();
            if (!(array[0] is T0))
                return null;
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
                return null;
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
                return null;
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
                return null;
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
                return null;
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
                return null;
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
                return null;
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
                return null;
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
                return null;
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
                return null;
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
                return null;
            typizedNodeArray.K = (T10)array[10];

            if (!(array[11] is T11))
                return null;
            typizedNodeArray.L = (T11)array[11];

            if (!(array[12] is T12))
                return null;
            typizedNodeArray.M = (T12)array[12];

            return typizedNodeArray;
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0> : SelectWhereRule where T0 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1> : SelectWhereRule
        where T0 : INode
        where T1 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6> : SelectWhereRule
        where T0 : INode
        where T1 : INode
        where T2 : INode
        where T3 : INode
        where T4 : INode
        where T5 : INode
        where T6 : INode
    {
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : SelectWhereRule
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : SelectWhereRule
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : SelectWhereRule
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
        readonly Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> _where;

        public SelectWhereRule(SelectRule selectRule, Func<SelectOutput, TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> where)
            : base(selectRule)
        {
            _where = where;
        }

        public Rule Mod(Action<TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> replace)
        {
            return new Rule(SelectRule.NewRule.Name, SelectRule.NewRule.Tags, SelectRule.Selector, z => _where(z), z => replace((TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)z));
        }
    }
    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class SelectClauseWriter
    {
        public static SelectClauseNode AnyA
        {
            get
            {
                return new SelectClauseNode(0, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildA
        {
            get
            {
                return new SelectClauseNode(0, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode A
        {
            get
            {
                return new SelectClauseNode(0, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyB
        {
            get
            {
                return new SelectClauseNode(1, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildB
        {
            get
            {
                return new SelectClauseNode(1, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode B
        {
            get
            {
                return new SelectClauseNode(1, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyC
        {
            get
            {
                return new SelectClauseNode(2, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildC
        {
            get
            {
                return new SelectClauseNode(2, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode C
        {
            get
            {
                return new SelectClauseNode(2, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyD
        {
            get
            {
                return new SelectClauseNode(3, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildD
        {
            get
            {
                return new SelectClauseNode(3, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode D
        {
            get
            {
                return new SelectClauseNode(3, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyE
        {
            get
            {
                return new SelectClauseNode(4, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildE
        {
            get
            {
                return new SelectClauseNode(4, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode E
        {
            get
            {
                return new SelectClauseNode(4, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyF
        {
            get
            {
                return new SelectClauseNode(5, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildF
        {
            get
            {
                return new SelectClauseNode(5, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode F
        {
            get
            {
                return new SelectClauseNode(5, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyG
        {
            get
            {
                return new SelectClauseNode(6, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildG
        {
            get
            {
                return new SelectClauseNode(6, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode G
        {
            get
            {
                return new SelectClauseNode(6, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyH
        {
            get
            {
                return new SelectClauseNode(7, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildH
        {
            get
            {
                return new SelectClauseNode(7, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode H
        {
            get
            {
                return new SelectClauseNode(7, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyI
        {
            get
            {
                return new SelectClauseNode(8, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildI
        {
            get
            {
                return new SelectClauseNode(8, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode I
        {
            get
            {
                return new SelectClauseNode(8, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyJ
        {
            get
            {
                return new SelectClauseNode(9, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildJ
        {
            get
            {
                return new SelectClauseNode(9, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode J
        {
            get
            {
                return new SelectClauseNode(9, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyK
        {
            get
            {
                return new SelectClauseNode(10, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildK
        {
            get
            {
                return new SelectClauseNode(10, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode K
        {
            get
            {
                return new SelectClauseNode(10, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyL
        {
            get
            {
                return new SelectClauseNode(11, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildL
        {
            get
            {
                return new SelectClauseNode(11, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode L
        {
            get
            {
                return new SelectClauseNode(11, LetterRecursionType.No);
            }
        }

        public static SelectClauseNode AnyM
        {
            get
            {
                return new SelectClauseNode(12, LetterRecursionType.Subtree);
            }
        }

        public static SelectClauseNode ChildM
        {
            get
            {
                return new SelectClauseNode(12, LetterRecursionType.Children);
            }
        }

        public static SelectClauseNode M
        {
            get
            {
                return new SelectClauseNode(12, LetterRecursionType.No);
            }
        }

    }

    [GeneratedCode("ComputerAlgebra.Codegen", "1.0.0.1")]
    public class LogicExpressions
    {
        public static ComputerAlgebraBoolean K(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean L(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean M(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean N(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean O(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean P(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean Q(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean R(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static ComputerAlgebraBoolean S(params int[] args)
        {
            return new ComputerAlgebraBoolean();
        }
        public static int f(params int[] args)
        {
            return 1;
        }
        public static int g(params int[] args)
        {
            return 1;
        }
        public static int h(params int[] args)
        {
            return 1;
        }
        public static int i(params int[] args)
        {
            return 1;
        }
        public static int j(params int[] args)
        {
            return 1;
        }
        public static int k(params int[] args)
        {
            return 1;
        }
        public static int l(params int[] args)
        {
            return 1;
        }
        public static int m(params int[] args)
        {
            return 1;
        }
        public static int n(params int[] args)
        {
            return 1;
        }
        public const int a = 0;
        public const int b = 1;
        public const int c = 2;
        public const int d = 3;
        public const int e = 4;
    }
}
