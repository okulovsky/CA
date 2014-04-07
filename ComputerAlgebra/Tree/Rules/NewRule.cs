// ComputerAlgebra Library

// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at

using System.Collections.Generic;

namespace AIRLab.CA.Tree.Rules
{
    public class NewRule : INewRule
    {
        public string Name { get; private set; }
        public IEnumerable<string> Tags { get; private set; }
        public NewRule(string name, IEnumerable<string> tags)
        {
            Name = name;
            Tags = tags;
        }
    }
}
