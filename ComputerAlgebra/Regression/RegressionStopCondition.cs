// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

namespace AIRLab.CA.Regression
{
    /// <summary>
    /// Stop condition by number of iterations or the accuracy of approximation for regression algorithm.
    /// </summary>
    public class RegressionStopCondition
    {
        private readonly double _precision;
        private readonly int _iterationsCount;
        private int _idx;

        public RegressionStopCondition(double precision, int iterationsCount)
        {
            _precision = precision;
            _iterationsCount = iterationsCount;
        }

        public bool Check(double error)
        {
            if (_iterationsCount == 0)
                return error > _precision;
            var result = _idx < _iterationsCount;
            ++_idx;
            return result;
        }
    }
}