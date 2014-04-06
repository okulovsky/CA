// ComputerAlgebra Library
//
// Copyright © Medvedev Igor, Okulovsky Yuri, Borcheninov Jaroslav, Johann Dirry, 2014
// imedvedev3@gmail.com, yuri.okulovsky@gmail.com, yariksuperman@gmail.com, johann.dirry@aon.at
//

namespace AIRLab.CA.Groups
{
    /// <summary>
    /// The group F(2)
    /// </summary>
    public class BooleanGroup 
    {
        public static BooleanGroup operator |(BooleanGroup node1, BooleanGroup node2)
        {
            return new BooleanGroup();
        }

        public static BooleanGroup operator !(BooleanGroup node1)
        {
            return new BooleanGroup();
        }
    }
}
