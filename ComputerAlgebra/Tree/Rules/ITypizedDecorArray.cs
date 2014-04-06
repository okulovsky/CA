// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public interface ITypizedDecorArray<out T0> : IModInput
        where T0 : INode 
    {
        INodeDecorator<T0> A { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1> : IModInput
        where T0 : INode 
        where T1 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7> : IModInput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
        where T7 : INode 
    {
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8> : IModInput
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
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
        INodeDecorator<T8> I { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9> : IModInput
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
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
        INodeDecorator<T8> I { get; }
        INodeDecorator<T9> J { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10> : IModInput
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
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
        INodeDecorator<T8> I { get; }
        INodeDecorator<T9> J { get; }
        INodeDecorator<T10> K { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11> : IModInput
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
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
        INodeDecorator<T8> I { get; }
        INodeDecorator<T9> J { get; }
        INodeDecorator<T10> K { get; }
        INodeDecorator<T11> L { get; }
    }
    public interface ITypizedDecorArray<out T0, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12> : IModInput
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
        INodeDecorator<T0> A { get; }
        INodeDecorator<T1> B { get; }
        INodeDecorator<T2> C { get; }
        INodeDecorator<T3> D { get; }
        INodeDecorator<T4> E { get; }
        INodeDecorator<T5> F { get; }
        INodeDecorator<T6> G { get; }
        INodeDecorator<T7> H { get; }
        INodeDecorator<T8> I { get; }
        INodeDecorator<T9> J { get; }
        INodeDecorator<T10> K { get; }
        INodeDecorator<T11> L { get; }
        INodeDecorator<T12> M { get; }
    }
}