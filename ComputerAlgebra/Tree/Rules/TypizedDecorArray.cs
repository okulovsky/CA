// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System.Collections.Generic;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public class TypizedDecorArray<T0> : ModInput, ITypizedDecorArray<T0>
        where T0 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
        }
    }
    public class TypizedDecorArray<T0, T1> : ModInput, ITypizedDecorArray<T0, T1>
        where T0 : INode 
        where T1 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
        }
    }
    public class TypizedDecorArray<T0, T1, T2> : ModInput, ITypizedDecorArray<T0, T1, T2>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3> : ModInput, ITypizedDecorArray<T0, T1, T2, T3>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
        { 
            A = new NodeDecorator<T0>(this, (T0)c[0]);
            B = new NodeDecorator<T1>(this, (T1)c[1]);
            C = new NodeDecorator<T2>(this, (T2)c[2]);
            D = new NodeDecorator<T3>(this, (T3)c[3]);
            E = new NodeDecorator<T4>(this, (T4)c[4]);
            F = new NodeDecorator<T5>(this, (T5)c[5]);
        }
    }
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }

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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7>
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
        where T7 : INode 
    {
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>
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
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }
        public INodeDecorator<T8> I { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
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
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }
        public INodeDecorator<T8> I { get; private set; }
        public INodeDecorator<T9> J { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
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
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }
        public INodeDecorator<T8> I { get; private set; }
        public INodeDecorator<T9> J { get; private set; }
        public INodeDecorator<T10> K { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
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
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }
        public INodeDecorator<T8> I { get; private set; }
        public INodeDecorator<T9> J { get; private set; }
        public INodeDecorator<T10> K { get; private set; }
        public INodeDecorator<T11> L { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
    public class TypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ModInput, ITypizedDecorArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
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
        public INodeDecorator<T0> A { get; private set; }
        public INodeDecorator<T1> B { get; private set; }
        public INodeDecorator<T2> C { get; private set; }
        public INodeDecorator<T3> D { get; private set; }
        public INodeDecorator<T4> E { get; private set; }
        public INodeDecorator<T5> F { get; private set; }
        public INodeDecorator<T6> G { get; private set; }
        public INodeDecorator<T7> H { get; private set; }
        public INodeDecorator<T8> I { get; private set; }
        public INodeDecorator<T9> J { get; private set; }
        public INodeDecorator<T10> K { get; private set; }
        public INodeDecorator<T11> L { get; private set; }
        public INodeDecorator<T12> M { get; private set; }

        public TypizedDecorArray(IList<INode> c) 
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
}
