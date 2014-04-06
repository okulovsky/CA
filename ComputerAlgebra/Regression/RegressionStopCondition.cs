// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

namespace AIRLab.CA.Regression
{
    /// <summary>
    /// Stop condition by number of iterations or the accuracy of approximation for regression algorithm.
    /// </summary>
    public class RegressionStopCondition
    {
        private readonly double _requiredPrecision;
        private readonly int _maxIterations;
        private int _iterations;

        public RegressionStopCondition(double requiredPrecision, int maxIterations)
        {
            _requiredPrecision = requiredPrecision;
            _maxIterations = maxIterations;
        }

        public bool Check(double error)
        {
            if (_maxIterations == 0)
                return error > _requiredPrecision;

            var result = _iterations < _maxIterations;
            _iterations += 1;
            return result;
        }
    }
}