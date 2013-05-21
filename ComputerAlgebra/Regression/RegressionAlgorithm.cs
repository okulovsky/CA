// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections;
using AIRLab.CA.RulesCollection;
using AIRLab.CA.Tools;
using AIRLab.CA.Tree;

namespace AIRLab.CA.Regression
{
    /// <summary>
    /// Implementatuin of simple linear regression algorithm
    /// </summary>
    public class RegressionAlgorithm
    {
        public INode Formula { get; private set; }
        public List<double> InConstant { get; private set; }
        public int CurrentIteration { get; private set; }
        public double ApproximationError { get; private set; }

        private readonly List<double[]> _inSamples = new List<double[]>();        
        private readonly List<double> _exactResult = new List<double>();
        private readonly double _precision;
        private double _lambda;
        private List<double> _oldGradient = new List<double>(); 
        private const double ConstantRate = 0.01;
        private const double ApproximationErrorRate = 0.0001;
        
        private const int MaxIterationCount = 1000;
        private bool _success = true;
        private readonly Func<IList, double> _functional;

        private const String VarName = "c";
        private static int _index;       

        public RegressionAlgorithm(INode expression, List<double[]> arguments, List<double> result)
            :this(expression, arguments, result, 0.0001, 0.0001)
        { }

        public RegressionAlgorithm(INode expression, List<double[]> arguments, List<double> result, double accurance, double lambda)
        {
            _inSamples = arguments;
            _exactResult = result;
            _precision = accurance;
            _lambda = lambda;
            Formula = expression.Clone<INode>();
            InConstant = new List<double>();
            BuildFunctional();
            _functional = Formula.ComplileDelegate<double>();
            ApproximationError = GetApproximationError(InConstant);
        }

        public void Run(int interationCount = 0)
        {
            var condition = new RegressionStopCondition(_precision, interationCount);
            while (condition.Check(ApproximationError))
            {
                MakeIteration();
                if (CurrentIteration > MaxIterationCount)
                {
                    _success = false;
                    break;
                }
            }
            if (InConstant.Exists(double.IsNaN) || InConstant.Exists(double.IsInfinity))
            {
                _success = false;
                return;
            }
        }

        public void MakeIteration()
        {
            var gradient = MakeGradientStep(InConstant);
            if (_oldGradient.Count != 0)
            {
                double num = gradient.Select((t, i) => t * _oldGradient[i]).Sum();
                double den =
                    Math.Sqrt(gradient.Aggregate((x, y) => Math.Pow(x, 2.0)+Math.Pow(y, 2.0))*
                              _oldGradient.Aggregate((x, y) => Math.Pow(x, 2.0)+Math.Pow(y, 2.0)));
                double alfa = Math.Acos(Math.Round(num / den, 15));
                _lambda *= GetFactor(alfa);
            }
            _oldGradient = gradient.Copy();
            for (var i = 0; i < InConstant.Count; i++)
            {
                InConstant[i] -= _lambda * gradient[i];
            }
            ApproximationError = GetApproximationError(InConstant);
        }

        /// <summary>
        /// Return result formula. null - if calculation runs too long and has been stoped.
        /// </summary>
        /// <returns></returns>
        public INode GetResult()
        {
            if(_success)
            {
                // replace variables by calculated contants
                RebuildTree(Formula, false);
                return Formula;
            }
            return null;
        }

        private double GetApproximationError(List<double> constantSet)
        {
            double sum = 0;
            for (var i = 0; i < _inSamples.Count; i++)
            {
                var resultSet = _inSamples[i].ToList();
                resultSet.AddRange(constantSet);
                sum += Math.Pow(_functional.Invoke(resultSet) - _exactResult[i], 2.0);
            }
            return sum;
        }
        /// <summary>
        /// Gradient
        /// </summary>
        /// <param name="constantSet"></param>
        /// <returns></returns>
        private List<double> MakeGradientStep(List<double> constantSet)
        {
            CurrentIteration++;
            var gradient = new List<double>(); 
            for (var c = _index - InConstant.Count; c < _index; c++)
            {
                var funcDiff = ComputerAlgebra.Differentiate(Formula, c).ComplileDelegate<double>();
                double step = 0;
                for (var i = 0; i < _inSamples.Count; i++)
                {
                    var resultSet = _inSamples[i].ToList();
                    resultSet.AddRange(constantSet);
                    var funcResult = _functional.Invoke(resultSet);
                    var diffResult = funcDiff.Invoke(resultSet);
                    if (!(double.IsNaN(funcResult) || double.IsNaN(diffResult) || double.IsNaN(_exactResult[i])
                        || double.IsInfinity(funcResult) || double.IsInfinity(diffResult) || double.IsInfinity(_exactResult[i])))
                    {
                        step += 2 * (funcResult - _exactResult[i]) * diffResult;
                    }
                }
                gradient.Add(step);
            }
            return gradient;
        }

        private static double GetFactor(double alfa)
        {
            if (double.IsNaN(alfa))
                return 1;
            if (alfa < Math.PI/6)
                return 2;
            if (Math.PI / 6 <= alfa && alfa <= Math.PI / 2)
                return 1;
            return 1.0/3;
        }

        private INode BuildFunctional()
        {
            _index = Formula.GetVariableCount();
            RebuildTree(Formula, true);            
            return Formula;
        }

        /// <summary>
        /// Rebuilds the tree nodes
        /// </summary>
        /// <param name="node">Tree (root node)</param>
        /// <param name="replaceConstant">If true - replaces all of the constants by new variables
        ///                               else - replaces all of the new variables by calculated contants from _inContants list</param>
        private void RebuildTree(INode node, bool replaceConstant)
        {
            if (node.HasChildren())
            {
                foreach (var child in node.Children)
                {
                    RebuildTree(child, replaceConstant);
                }
            }
            else
            {
                if (node is Constant && replaceConstant)
                {
                    InConstant.Add(Double.Parse(node.ToString()));
                    var childIndex = node.Parent.IndexOfChild(node);
                    INode newVar = VariableNode.Make<double>(_index, VarName + (InConstant.Count-1));
                    node.Parent.Children[childIndex] = newVar;
                    _index++;                    
                }
                if (node is VariableNode && !replaceConstant)
                {
                    if (((VariableNode)node).Index >= _index - InConstant.Count)
                    {
                        var childIndex = node.Parent.IndexOfChild(node);
                        INode newVar = Constant.Double(InConstant[((VariableNode)node).Index-(_index - InConstant.Count)]);
                        node.Parent.Children[childIndex] = newVar;
                    }
                }
            }            
        }
    }
}
