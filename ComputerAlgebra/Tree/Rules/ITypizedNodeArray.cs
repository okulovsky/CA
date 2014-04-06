// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public interface ITypizedNodeArray<T0> : IWhereOutput
        where T0 : INode 
    {
        T0 A { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7> : IWhereOutput
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
        where T7 : INode 
    {
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IWhereOutput
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
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
        T8 I { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IWhereOutput
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
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
        T8 I { get; set; }
        T9 J { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IWhereOutput
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
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
        T8 I { get; set; }
        T9 J { get; set; }
        T10 K { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IWhereOutput
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
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
        T8 I { get; set; }
        T9 J { get; set; }
        T10 K { get; set; }
        T11 L { get; set; }
    }
    public interface ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IWhereOutput
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
        T0 A { get; set; }
        T1 B { get; set; }
        T2 C { get; set; }
        T3 D { get; set; }
        T4 E { get; set; }
        T5 F { get; set; }
        T6 G { get; set; }
        T7 H { get; set; }
        T8 I { get; set; }
        T9 J { get; set; }
        T10 K { get; set; }
        T11 L { get; set; }
        T12 M { get; set; }
    }
}