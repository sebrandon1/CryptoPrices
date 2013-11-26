/*
 * CryptoCode.cs -- Change Log:
 * 
 *      11-26-2013: Created class.  (Brandon)
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml;
using System.Globalization;

namespace CryptoPrices.Classes
{
    public class CryptoCode
    {
        // BTC Price API URLs
        static string CoinBase_BTC_USD_URL = "https://coinbase.com/api/v1/prices/spot_rate";
        static string BitStamp_BTC_USD_URL = "https://www.bitstamp.net/api/ticker/";
        static string MtGox_BTC_USD_URL = "http://data.mtgox.com/api/2/BTCUSD/money/ticker_fast";
        static string BTCe_BTC_USD_URL = "https://btc-e.com/api/2/btc_usd/ticker";

        public double GetCoinbaseRate()
        {
            /*
             * Function Notes:
             * 
             *      11-26-2013: Function created. (Brandon)
             * */

            double value = 0.0;

            return value;

        } // GetCoinbaseRate()

        public double GetBitstampRate()
        {
            /*
             * Function Notes:
             * 
             *      11-26-2013: Function created. (Brandon)
             * */

            double value = 0.0;

            return value;
        } // GetBitstampRate()

        public double GetMtGoxRate()
        {
            /*
             * Function Notes:
             * 
             *      11-26-2013: Function created. (Brandon)
             * */

            double value = 0.0;

            return value;
        } // GetMtGoxRate()

        public double GetBTCeRate()
        {
            /*
             * Function Notes:
             * 
             *      11-26-2013: Function created. (Brandon)
             * */

            double value = 0.0;

            return value;

        } // GetBTCeRate()


    }
}