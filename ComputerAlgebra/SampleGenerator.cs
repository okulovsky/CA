// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Linq;
using System.Collections.Generic;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace AIRLab.CA
{
    /// <summary>
    /// Class for generation random formulas
    /// </summary>
    public class SampleGenerator
    {
        private static readonly Random Rnd = new Random();
        public List<double[]> InSamples { get; private set; }
        public List<double> RandomizedResult { get; private set; }
        public List<double> ExactResult { get; private set; }
        private const double Delta = 0.1;
        private const double Min = 0;
        private const double Max = 1;
        private readonly int _varCount;
        private readonly int _operCount;
        private readonly double _noiseLevel;
        private const double EPSILON = 0.00000001;

        public SampleGenerator(int varCount, int operCount, double noise)
        {
            _varCount = varCount;
            _operCount = operCount;
            _noiseLevel = noise;
            InSamples = new List<double[]>();
            RandomizedResult = new List<double>();
            ExactResult = new List<double>();
        }

        public INode GetFormula()
        {
            INode formula = null;
            while (true)
            {
                formula = GenerateFormula(_operCount, _varCount);                
                var function = formula.ComplileDelegate<double>();

                InSamples = new List<double[]>(Arguments(_varCount, 0, null, Min, Max, Delta));
                ExactResult = new List<double>(InSamples.Select(function).ToArray());
                RandomizedResult = new List<double>(ExactResult.Select(z => z * (1 - _noiseLevel + 2 * Rnd.NextDouble() * _noiseLevel)).ToArray());

                if (CheckValid(ExactResult) || CheckValid(RandomizedResult) || CheckVarsCount(_varCount))
                {
                    continue;
                }
                break;
            }
            return formula;
        }
        public static IEnumerable<double[]> Arguments(int count, int step, double[] temp, double min, double max, double delta)
        {
            if (temp == null)
                temp = new double[count];

            for (var v = min; v <= max; v += delta)
            {
                temp[step] = v;
                if (step != count - 1)
                    foreach (var e in Arguments(count, step + 1, temp, min, max, delta))
                        yield return e;
                else
                    yield return temp.ToArray();
            }
        }
        /// <summary>
        /// Check the significance of each variable
        /// </summary>
        /// <returns>true - degenerate case</returns>
        private bool CheckVarsCount(int realVarsCount)
        {
            for (var i = 0; i < realVarsCount; i++)
            {
                if (CheckOneVar(i))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Check the significance of one variable
        /// </summary>
        /// <param name="number">Variable number</param>
        private bool CheckOneVar(int number)
        {
            var step = (int)Math.Pow(((Max - Min) / Delta) + 1, (number));
            for (var i = 0; i < InSamples.Count - step; i++)
            {
                if (Math.Abs((i + 1) % ((Max - Min) / Delta + 1) - 0) < EPSILON)
                    continue;
                if (Math.Abs(ExactResult[i] - ExactResult[i + step]) > EPSILON)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Check the correctness of generated formulas (without NaN, Infitity) 
        /// </summary>
        /// <returns>true - correct</returns>
        private static bool CheckValid(List<double> result)
        {
            return (result.Exists(double.IsNaN) || result.Exists(double.IsInfinity));
        }

        protected BinaryOp GenerateFormula(int operationsCount, int variableCount)
        {
            var formula = new List<BinaryOp>();
            var constCount = operationsCount - variableCount + 1;
            var listsCount = (int)Math.Ceiling(operationsCount / 2.0);
            // leafs generation             
            var uniqueVars = GetUniqueRandom(variableCount);
            if (listsCount < variableCount)
            {
                for (var i = 0; i < variableCount; i += 2)
                {
                    if ((i + 1) < variableCount)
                    {
                        formula.Add(GetRandomOperation(VariableNode.Make<double>(uniqueVars[i], NodeElementNames.GetVariableNodeNames().ElementAt(uniqueVars[i])),
                                                       VariableNode.Make<double>(uniqueVars[i + 1], NodeElementNames.GetVariableNodeNames().ElementAt(uniqueVars[i + 1]))));
                    }
                    else
                    {
                        formula.Add(GetRandomOperation(VariableNode.Make<double>(uniqueVars[i], 
                            NodeElementNames.GetVariableNodeNames().ElementAt(uniqueVars[i])), Constant.Double(Rnd.Next(constCount) + 2)));
                    }
                }
            }
            else
            {
                for (var i = 0; i < variableCount; i++)
                {
                    formula.Add(GetRandomOperation(VariableNode.Make<double>(uniqueVars[i], NodeElementNames.GetVariableNodeNames().ElementAt(uniqueVars[i])), 
                                                        Constant.Double(Rnd.Next(constCount) + 2)));
                }
                for (var i = 0; i < listsCount - variableCount; i++)
                {
                    var rndVars = Rnd.Next(variableCount);
                    formula.Add(GetRandomOperation(VariableNode.Make<double>(rndVars, NodeElementNames.GetVariableNodeNames().ElementAt(rndVars)), Constant.Double(Rnd.Next(constCount) + 2)));
                }
            }
            if (operationsCount % 2 == 0)
            {
                var rndVars = Rnd.Next(variableCount);
                formula[0] = GetRandomOperation(VariableNode.Make<double>(rndVars, NodeElementNames.GetVariableNodeNames().ElementAt(rndVars)), formula[0]);
            }
            // generation of arithmetic tree
            while (formula.Count != 1)
            {
                for (var j = 0; j < formula.Count - 1; j += 2)
                {
                    formula[j + 1] = GetRandomOperation(formula[j], formula[j + 1]);
                    formula[j] = null;
                }
                formula.RemoveAll(x => x == null);
            }
            return formula[0];
        }
        protected BinaryOp GetRandomOperation(INode child1, INode child2)
        {
            var rndOper = Rnd.Next(5); ;
            switch (rndOper)
            {
                case 0:
                    return new Arithmetic.Plus<double>(child1, child2);
                case 1:
                    return new Arithmetic.Minus<double>(child1, child2);
                case 2:
                    return new Arithmetic.Product<double>(child1, child2);
                case 3:
                    return new Arithmetic.Divide<double>(child1, child2);
                case 4:
                    return new Arithmetic.Pow<double>(child1, child2);
            }
            return new Arithmetic.Plus<double>(child1, child2);
        }
        protected List<int> GetUniqueRandom(int length)
        {
            var count = 0;
            var uniqueList = new int[length];
            while (count < length)
            {
                var tmp = Rnd.Next(length);
                if (uniqueList[tmp] != 0) continue;
                uniqueList[tmp] = count;
                count++;
            }
            return uniqueList.ToList();
        }
    }
}