/*
 * BTCe_BTC.cs -- Change Log:
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
    public class BTCe_BTC
    {
        public class Ticker
        {
            public int high { get; set; }
            public int low { get; set; }
            public int avg { get; set; }
            public double vol { get; set; }
            public double vol_cur { get; set; }
            public int last { get; set; }
            public int buy { get; set; }
            public double sell { get; set; }
            public int updated { get; set; }
            public int server_time { get; set; }
        }

        public class data
        {
            public Ticker ticker { get; set; }
        }
    }
}