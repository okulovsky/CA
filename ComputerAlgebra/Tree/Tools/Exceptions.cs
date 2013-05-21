using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIRLab.CA.Tools
{
    public class CAException : ApplicationException
    {
        public CAException(string message) : base(message)
        { }

        public CAException(string message, Exception innerException)
            : base(message + string.Format("\nInner exception message: {0}", innerException.Message), innerException)
        { }
    }

    public class ParseException : CAException
    {
        public ParseException(string message)
            : base(message)
        { }

        public ParseException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
