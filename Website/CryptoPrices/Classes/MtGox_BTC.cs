/*
 * MtGox_BTC.cs -- Change Log:
 * 
 *      12-31-2013: Created change class. (Brandon)
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoPrices.Classes
{
    public class MtGox_BTC
    {
        public class LastLocal
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Last
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class LastOrig
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class LastAll
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Buy
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Sell
        {
            public string value { get; set; }
            public string value_int { get; set; }
            public string display { get; set; }
            public string display_short { get; set; }
            public string currency { get; set; }
        }

        public class Data
        {
            public LastLocal last_local { get; set; }
            public Last last { get; set; }
            public LastOrig last_orig { get; set; }
            public LastAll last_all { get; set; }
            public Buy buy { get; set; }
            public Sell sell { get; set; }
            public string now { get; set; }
        }

        public class Gox
        {
            public string result { get; set; }
            public Data data { get; set; }
        }
    }
}