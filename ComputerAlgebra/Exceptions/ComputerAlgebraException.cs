// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;

namespace AIRLab.CA.Exceptions
{
    public class ComputerAlgebraException : ApplicationException
    {
        public ComputerAlgebraException(string message) : base(message)
        { }

        public ComputerAlgebraException(string message, Exception innerException)
            : base(string.Format("{0}{2}Inner exception message: {1}", message, innerException.Message, Environment.NewLine), innerException)
        { }
    }
}
