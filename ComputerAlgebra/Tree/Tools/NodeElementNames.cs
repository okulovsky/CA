// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AIRLab.CA.Tree.Tools
{
    public static class NodeElementNames
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";

        public static IEnumerable<String> GetVariableNodeNames()
        {
            for (var i = LowerCaseLetters.IndexOf("u", StringComparison.Ordinal); i < LowerCaseLetters.Length; i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString(CultureInfo.InvariantCulture);
            }
            for (var i = 0; i < LowerCaseLetters.IndexOf("u", StringComparison.Ordinal); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString(CultureInfo.InvariantCulture);
            }
        }

        public static IEnumerable<String> GetPredicateNames()
        {
            for (var i = Letters.IndexOf("K", StringComparison.Ordinal); i < Letters.IndexOf("T", StringComparison.Ordinal); i++)
            {
                yield return Letters.ElementAt(i).ToString(CultureInfo.InvariantCulture);
            }
        }

        public static IEnumerable<String> GetFunctionNames()
        {
            for (var i = LowerCaseLetters.IndexOf("f", StringComparison.Ordinal); i < LowerCaseLetters.IndexOf("o", StringComparison.Ordinal); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString(CultureInfo.InvariantCulture);
            }
        }

        public static IEnumerable<String> GetConstantNames()
        {
            for (var i = 0; i < LowerCaseLetters.IndexOf("f", StringComparison.Ordinal); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
