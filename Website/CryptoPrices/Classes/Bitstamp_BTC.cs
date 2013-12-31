/*
 * Bitstamp_BTC.cs -- Change Log:
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
    public class Bitstamp_BTC
    {
        public class data
        {
            public string high { get; set; }
            public string last { get; set; }
            public string timestamp { get; set; }
            public string bid { get; set; }
            public string volume { get; set; }
            public string low { get; set; }
            public string ask { get; set; }
        }
    }
}