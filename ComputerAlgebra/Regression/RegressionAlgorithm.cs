// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AIRLab.CA.Tree.Nodes;
using AIRLab.CA.Tree.Tools;

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

        private readonly IList<double[]> _inSamples;
        private readonly IList<double> _exactResult;
        private readonly double _precision;
        private double _lambda;
        private IList<double> _oldGradient = new List<double>(); 

        private const int MaxIterationCount = 1000;
        private bool _success = true;
        private readonly Func<IList, double> _functional;

        private const String VarName = "c";
        private static int _index;

        public RegressionAlgorithm(INode expression, IList<double[]> arguments, IList<double> result, double accurance = 0.0001, double lambda = 0.0001)
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
                if (CurrentIteration <= MaxIterationCount) 
                    continue;

                _success = false;
                break;
            }

            if (!InConstant.Exists(double.IsNaN) && !InConstant.Exists(double.IsInfinity)) 
                return;

            _success = false;
        }

        public void MakeIteration()
        {
            var gradient = MakeGradientStep(InConstant);

            if (_oldGradient.Count != 0)
            {
                var numerator = gradient.Select((t, i) => t * _oldGradient[i]).Sum();
                var denumerator =
                    Math.Sqrt(gradient.Aggregate((x, y) => Math.Pow(x, 2.0)+Math.Pow(y, 2.0))*
                              _oldGradient.Aggregate((x, y) => Math.Pow(x, 2.0)+Math.Pow(y, 2.0)));
                var alfa = Math.Acos(Math.Round(numerator / denumerator, 15));
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
        /// Get the calculated formula. 
        /// </summary>
        /// <returns>The resulting formular. <c>null</c> if the calculation runs too long and has been stoped.</returns>
        public INode GetResult()
        {
            if (!_success) 
                return null;

            // replace variables by calculated contants
            RebuildTree(Formula, false);
            return Formula;
        }

        private double GetApproximationError(IList<double> constantSet)
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
                var funcDiff = CA.ComputerAlgebra.Differentiate(Formula, c).ComplileDelegate<double>();
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

        private void BuildFunctional()
        {
            _index = Formula.GetVariableCount();
            RebuildTree(Formula, true);
        }

        /// <summary>
        /// Rebuilds the tree nodes
        /// </summary>
        /// <param name="node">Tree (root node)</param>
        /// <param name="replaceConstant">
        /// Replaces all of the constants by new variables when true.
        /// Replaces all of the new variables by calculated contants from _inContants list when false.
        /// </param>
        private void RebuildTree(INode node, bool replaceConstant)
        {
            if (node.HasChildren())
            {
                foreach (var child in node.Children)
                {
                    RebuildTree(child, replaceConstant);
                }
                return;
            }
            
            int childIndex;
            INode newVar;

            if (node is Constant && replaceConstant)
            {
                InConstant.Add(Double.Parse(node.ToString()));
                childIndex = node.Parent.IndexOfChild(node);
                newVar = VariableNode.Make<double>(_index, VarName + (InConstant.Count-1));
                node.Parent.Children[childIndex] = newVar;
                _index++;
            }

            if (!(node is VariableNode) || replaceConstant) 
                return;

            if (((VariableNode) node).Index < _index - InConstant.Count) 
                return;

            childIndex = node.Parent.IndexOfChild(node);
            newVar = new Constant<double>(InConstant[((VariableNode)node).Index-(_index - InConstant.Count)]);
            node.Parent.Children[childIndex] = newVar;
        }
    }
}
