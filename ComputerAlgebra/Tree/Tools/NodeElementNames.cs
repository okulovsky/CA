// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, 2013
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com
//

using System;
using System.Collections.Generic;
using System.Linq;

namespace AIRLab.CA.Tools
{
    public static class NodeElementNames
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";

        public static IEnumerable<String> GetVariableNodeNames()
        {
            for (var i = LowerCaseLetters.IndexOf("u"); i < LowerCaseLetters.Length; i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString();
            }
            for (var i = 0; i < LowerCaseLetters.IndexOf("u"); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString();
            }
        }

        public static IEnumerable<String> GetPredicateNames()
        {
            for (var i = Letters.IndexOf("K"); i < Letters.IndexOf("T"); i++)
            {
                yield return Letters.ElementAt(i).ToString();
            }
        }

        public static IEnumerable<String> GetFunctionNames()
        {
            for (var i = LowerCaseLetters.IndexOf("f"); i < LowerCaseLetters.IndexOf("o"); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString();
            }
        }

        public static IEnumerable<String> GetConstantNames()
        {
            for (var i = 0; i < LowerCaseLetters.IndexOf("f"); i++)
            {
                yield return LowerCaseLetters.ElementAt(i).ToString();
            }
        }
    }
}
