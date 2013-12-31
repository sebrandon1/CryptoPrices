/*
 * Coinbase_BTC.cs -- Change Log:
 * 
 *      12-31-2013: Created change class. (Brandon)
 *                  Added Spot and Buy/Sell data classes. (Brandon)
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoPrices.Classes
{
    public class Coinbase_BTC
    {
        #region Spot Data
        public class spot_data
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }
        #endregion

        #region Buy and Sell Data
        public class Subtotal
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Coinbase
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Bank
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class Fee
        {
            public Coinbase coinbase { get; set; }
            public Bank bank { get; set; }
        }

        public class Total
        {
            public string amount { get; set; }
            public string currency { get; set; }
        }

        public class buy_sell_data
        {
            public Subtotal subtotal { get; set; }
            public List<Fee> fees { get; set; }
            public Total total { get; set; }
            public string amount { get; set; }
            public string currency { get; set; }
        }
        #endregion

    }
}