/*
 * CryptoCode.cs -- Change Log:
 * 
 *      11-26-2013: Created class.  (Brandon)
 *      
 *      12-31-2013: Fleshed out public classes used by JSON objects. (Brandon)
 *                  Changed all URLs to use HTTPs for added security. (Brandon)
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Xml;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;

namespace CryptoPrices.Classes
{
    public class CryptoCode
    {
        // BTC Price API URLs
        static string CoinBase_BTC_Spot_URL = "https://coinbase.com/api/v1/prices/spot_rate";
        static string CoinBase_BTC_Buy_URL = "https://coinbase.com/api/v1/prices/buy";
        static string CoinBase_BTC_Sell_URL = "https://coinbase.com/api/v1/prices/sell";

        static string BitStamp_BTC_USD_URL = "https://www.bitstamp.net/api/ticker/";
        static string MtGox_BTC_USD_URL = "https://data.mtgox.com/api/2/BTCUSD/money/ticker_fast";
        static string BTCe_BTC_USD_URL = "https://btc-e.com/api/2/btc_usd/ticker";


        public double GetCoinbaseBuyRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(CoinBase_BTC_Buy_URL);

                // Store into object.
                Classes.Coinbase_BTC.buy_sell_data myCoinbase = JsonConvert.DeserializeObject<Classes.Coinbase_BTC.buy_sell_data>(myString);

                // Pull the value out of the object.
                value = Math.Round(Convert.ToDouble(myCoinbase.subtotal.amount), 2);
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetCoinbaseBuyRate_BTC()

        public double GetCoinbaseSellRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(CoinBase_BTC_Sell_URL);

                // Store into object.
                Classes.Coinbase_BTC.buy_sell_data myCoinbase = JsonConvert.DeserializeObject<Classes.Coinbase_BTC.buy_sell_data>(myString);

                // Pull the value out of the object.
                value = Math.Round(Convert.ToDouble(myCoinbase.subtotal.amount), 2);
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetCoinbaseSellRate_BTC()

        public double GetCoinbaseSpotRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(CoinBase_BTC_Spot_URL);

                // Store into object.
                Classes.Coinbase_BTC.spot_data myCoinbase = JsonConvert.DeserializeObject<Classes.Coinbase_BTC.spot_data>(myString);

                // Pull the value out of the object.
                value = Math.Round(Convert.ToDouble(myCoinbase.amount), 2);
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetCoinbaseSpotRate_BTC()

        public double GetBitstampBuyRate_BTC()
        {
            double value = 0.0;

            return value;
        } // GetBitstampBuyRate_BTC()

        public double GetBitstampSellRate_BTC()
        {
            double value = 0.0;

            return value;

        } // GetBitstampSellRate_BTC()

        public double GetMtGoxBuyRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(MtGox_BTC_USD_URL);

                // Store into object.
                Classes.MtGox_BTC.Gox myGox = JsonConvert.DeserializeObject<Classes.MtGox_BTC.Gox>(myString);

                // Pull the value out of the object.
                value = Math.Round(Convert.ToDouble(myGox.data.buy.value));
            }
            catch
            {
                value = 0.0;
            }

            return value;
        } // GetMtGoxBuyRate_BTC()

        public double GetMtGoxSellRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(MtGox_BTC_USD_URL);

                // Store into object.
                Classes.MtGox_BTC.Gox myGox = JsonConvert.DeserializeObject<Classes.MtGox_BTC.Gox>(myString);

                // Pull the value out of the object.
                value = Math.Round(Convert.ToDouble(myGox.data.sell.value), 2);
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetMtGoxSellRate_BTC()

        public double GetBTCeBuyRate_BTC()
        {

            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(BTCe_BTC_USD_URL);

                // Deserialize the array.
                var result = JsonConvert.DeserializeObject<dynamic>(myString);
                double temp = result.ticker.buy;

                // Pull the value out of the object.
                value = Math.Round(temp, 2);

                
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetBTCeBuyRate_BTC()

        public double GetBTCeSellRate_BTC()
        {
            double value = 0.0;

            try
            {
                // Create new WebClient to do the REST call.
                WebClient myClient = new WebClient();

                // Download the serialized string.
                string myString = myClient.DownloadString(BTCe_BTC_USD_URL);

                // Deserialize the array.
                var result = JsonConvert.DeserializeObject<dynamic>(myString);
                double temp = result.ticker.sell;

                // Pull the value out of the object.
                value = Math.Round(temp, 2);
            }
            catch
            {
                value = 0.0;
            }

            return value;

        } // GetBTCeSellRate_BTC()

    }
}