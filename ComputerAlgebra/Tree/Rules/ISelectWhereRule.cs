// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public interface ISelectWhereRule
    {
        ISelectRule SelectRule { get; }
    }
    public interface ISelectWhereRule<T0> : ISelectWhereRule
        where T0 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> : ISelectWhereRule
        where T0 : INode 
        where T1 : INode 
        where T2 : INode 
        where T3 : INode 
        where T4 : INode 
        where T5 : INode 
        where T6 : INode 
        where T7 : INode 
    {
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> : ISelectWhereRule
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
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ISelectWhereRule
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
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ISelectWhereRule
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
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ISelectWhereRule
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
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> Invoke { get; }
    }
    public interface ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ISelectWhereRule
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
        Func<ISelectOutput, ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> Invoke { get; }
    }
}