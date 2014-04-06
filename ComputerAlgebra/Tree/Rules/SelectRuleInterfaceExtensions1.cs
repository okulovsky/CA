// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System;
using System.Collections.Generic;
using AIRLab.CA.Tree.Nodes;

namespace AIRLab.CA.Tree.Rules
{
    public static class SelectRuleInterfaceExtensions
    {

        public static ISelectWhereRule<T0> Where<T0>(this ISelectRule rule)
            where T0 : INode 
        {
            return rule.Where<T0>(z => true);
        }

        public static ISelectWhereRule<T0> Where<T0>(this ISelectRule rule, Func<ITypizedNodeArray<T0>, bool> where)
            where T0 : INode 
        {
            return new SelectWhereRule<T0>(rule, selector =>
            {
                var tna = Typize<T0>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0> Typize<T0>(IList<INode> array)
            where T0 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1> Where<T0, T1>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
        {
            return rule.Where<T0, T1>(z => true);
        }

        public static ISelectWhereRule<T0, T1> Where<T0, T1>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1>, bool> where)
            where T0 : INode 
            where T1 : INode 
        {
            return new SelectWhereRule<T0, T1>(rule, selector =>
            {
                var tna = Typize<T0, T1>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1> Typize<T0, T1>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2> Where<T0, T1, T2>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
        {
            return rule.Where<T0, T1, T2>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2> Where<T0, T1, T2>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
        {
            return new SelectWhereRule<T0, T1, T2>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2> Typize<T0, T1, T2>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
        {
            return rule.Where<T0, T1, T2, T3>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3> Where<T0, T1, T2, T3>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
        {
            return new SelectWhereRule<T0, T1, T2, T3>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3> Typize<T0, T1, T2, T3>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
        {
            return rule.Where<T0, T1, T2, T3, T4>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4> Where<T0, T1, T2, T3, T4>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4> Typize<T0, T1, T2, T3, T4>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
        {
            return rule.Where<T0, T1, T2, T3, T4, T5>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5> Where<T0, T1, T2, T3, T4, T5>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5> Typize<T0, T1, T2, T3, T4, T5>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
        {
            return rule.Where<T0, T1, T2, T3, T4, T5, T6>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6> Where<T0, T1, T2, T3, T4, T5, T6>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6> Typize<T0, T1, T2, T3, T4, T5, T6>(IList<INode> array)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
        {
            if (array == null)
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> Where<T0, T1, T2, T3, T4, T5, T6, T7>(this ISelectRule rule)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
        {
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7> Where<T0, T1, T2, T3, T4, T5, T6, T7>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>, bool> where)
            where T0 : INode 
            where T1 : INode 
            where T2 : INode 
            where T3 : INode 
            where T4 : INode 
            where T5 : INode 
            where T6 : INode 
            where T7 : INode 
        {
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7> Typize<T0, T1, T2, T3, T4, T5, T6, T7>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ISelectRule rule)
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
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
            {
                return null;
            }
            typizedNodeArray.I = (T8)array[8];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISelectRule rule)
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
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
            {
                return null;
            }
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
            {
                return null;
            }
            typizedNodeArray.J = (T9)array[9];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISelectRule rule)
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
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
            {
                return null;
            }
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
            {
                return null;
            }
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
            {
                return null;
            }
            typizedNodeArray.K = (T10)array[10];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISelectRule rule)
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
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
            {
                return null;
            }
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
            {
                return null;
            }
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
            {
                return null;
            }
            typizedNodeArray.K = (T10)array[10];

            if (!(array[11] is T11))
            {
                return null;
            }
            typizedNodeArray.L = (T11)array[11];

            return typizedNodeArray;
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISelectRule rule)
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
            return rule.Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(z => true);
        }

        public static ISelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Where<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISelectRule rule, Func<ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, bool> where)
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
            return new SelectWhereRule<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(rule, selector =>
            {
                var tna = Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(selector.SelectedNodes);
                if (tna == null)
                {
                    return null;
                }
                tna.SelectResult = selector;
                return where(tna) ? tna : null;
            });
        }

        private static ITypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Typize<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IList<INode> array)
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
            {
                return null;
            }
            var typizedNodeArray = new TypizedNodeArray<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>();

            if (!(array[0] is T0))
            {
                return null;
            }
            typizedNodeArray.A = (T0)array[0];

            if (!(array[1] is T1))
            {
                return null;
            }
            typizedNodeArray.B = (T1)array[1];

            if (!(array[2] is T2))
            {
                return null;
            }
            typizedNodeArray.C = (T2)array[2];

            if (!(array[3] is T3))
            {
                return null;
            }
            typizedNodeArray.D = (T3)array[3];

            if (!(array[4] is T4))
            {
                return null;
            }
            typizedNodeArray.E = (T4)array[4];

            if (!(array[5] is T5))
            {
                return null;
            }
            typizedNodeArray.F = (T5)array[5];

            if (!(array[6] is T6))
            {
                return null;
            }
            typizedNodeArray.G = (T6)array[6];

            if (!(array[7] is T7))
            {
                return null;
            }
            typizedNodeArray.H = (T7)array[7];

            if (!(array[8] is T8))
            {
                return null;
            }
            typizedNodeArray.I = (T8)array[8];

            if (!(array[9] is T9))
            {
                return null;
            }
            typizedNodeArray.J = (T9)array[9];

            if (!(array[10] is T10))
            {
                return null;
            }
            typizedNodeArray.K = (T10)array[10];

            if (!(array[11] is T11))
            {
                return null;
            }
            typizedNodeArray.L = (T11)array[11];

            if (!(array[12] is T12))
            {
                return null;
            }
            typizedNodeArray.M = (T12)array[12];

            return typizedNodeArray;
        }
    }
}