/*
 * Default.aspx.cs -- Change Log:
 * 
 *      12-31-2013: Added change log section. (Brandon)
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CryptoPrices
{
    public partial class Default : System.Web.UI.Page
    {
        // Object Declarations
        Classes.CryptoCode myCrypto = new Classes.CryptoCode();

        // Enumerations
        enum FIAT { USD, EUR };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate current buy prices.
                PopulateAllPrices();
            }
            else
            {

            }

            
            
        } // Page_Load

        protected void PopulateAllPrices()
        {
            // Current Rates
            string goxBuyRate               = Convert.ToString(myCrypto.GetMtGoxBuyRate_BTC());
            string goxSellRate              = Convert.ToString(myCrypto.GetMtGoxSellRate_BTC());
            string BTCebuyRate              = Convert.ToString(myCrypto.GetBTCeBuyRate_BTC());
            string BTCesellRate             = Convert.ToString(myCrypto.GetBTCeSellRate_BTC());
            string coinbaseBuyRate          = Convert.ToString(myCrypto.GetCoinbaseBuyRate_BTC());
            string coinbaseSellRate         = Convert.ToString(myCrypto.GetCoinbaseSellRate_BTC());

            // Mt Gox
            Session["MtGoxBuyRate_BTC_Prev"]    = goxBuyRate;
            Session["MtGoxSellRate_BTC_Prev"]   = goxSellRate;
            MtGoxBuyLBL.Text    = goxBuyRate + " USD";
            MtGoxSellLBL.Text   = goxSellRate + " USD";

            // BTC-e
            Session["BTCeBuyRate_BTC_Prev"]     = BTCebuyRate;
            Session["BTCeSellRate_BTC_Prev"]    = BTCesellRate;
            BTCeBuyLBL.Text     = BTCebuyRate + " USD";
            BTCeSellLBL.Text    = BTCesellRate + " USD";

            // Coinbase
            Session["coinbaseBuyRate_BTC_Prev"]     = coinbaseBuyRate;
            Session["coinbaseSellRate_BTC_Prev"]    = coinbaseSellRate;
            CoinBaseBuyLBL.Text     = coinbaseBuyRate + " USD";
            CoinbaseSellLBL.Text    = coinbaseSellRate + " USD";

        } // PopulateAllPrices

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            // Call the API.
            double buyRate = myCrypto.GetMtGoxBuyRate_BTC();
            double sellRate = myCrypto.GetMtGoxSellRate_BTC();

            MtGoxBuyLBL.Text = Convert.ToString(buyRate) + " USD";
            MtGoxSellLBL.Text = Convert.ToString(sellRate) + " USD";

            // Calculate +/- of rates.
            if (Session["MtGoxBuyRate_BTC_Prev"] != null && Session["MtGoxSellRate_BTC_Prev"] != null)
            {
                // Grab the previous BUY/SELL price.
                double buyPrev = Convert.ToDouble(Session["MtGoxBuyRate_BTC_Prev"]);
                double sellPrev = Convert.ToDouble(Session["MtGoxSellRate_BTC_Prev"]);

                double buyDiff = Math.Round(buyRate - buyPrev, 2);
                double sellDiff = Math.Round(sellRate - sellPrev, 2);

                if (buyDiff != 0)
                {
                    MtGoxBuyDiffLBL.Text = "(" + Convert.ToString(buyDiff) + ")";
                    Session["MtGoxBuyRate_BTC_Prev"] = buyRate;

                    if (buyDiff > 0)
                    {
                        MtGoxBuyDiffLBL.ForeColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        MtGoxBuyDiffLBL.ForeColor = System.Drawing.Color.Red;
                    }

                    MtGoxBuyDiffLBL.Visible = true;
                } // if

                if (sellDiff != 0)
                {
                    MtGoxSellDiffLBL.Text = "(" + Convert.ToString(sellDiff) + ")";
                    Session["MtGoxSellRate_BTC_Prev"] = sellRate;

                    if (sellDiff > 0)
                    {
                        MtGoxSellDiffLBL.ForeColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        MtGoxSellDiffLBL.ForeColor = System.Drawing.Color.Red;
                    }

                    MtGoxSellDiffLBL.Visible = true;

                } // if

            } // if

        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            double buyRate = myCrypto.GetBTCeBuyRate_BTC();
            double sellRate = myCrypto.GetBTCeSellRate_BTC();

            BTCeBuyLBL.Text = Convert.ToString(buyRate) + " USD";
            BTCeSellLBL.Text = Convert.ToString(sellRate) + " USD";

            if (Session["BTCeBuyRate_BTC_Prev"] != null && Session["BTCeSellRate_BTC_Prev"] != null)
            {
                double buyPrev = Convert.ToDouble(Session["BTCeBuyRate_BTC_Prev"]);
                double sellPrev = Convert.ToDouble(Session["BTCeSellRate_BTC_Prev"]);

                double buyDiff = Math.Round(buyRate - buyPrev, 2);
                double sellDiff = Math.Round(sellRate - sellPrev, 2);

                if (buyDiff != 0)
                {
                    BTCeBuyDiffLBL.Text = "(" + Convert.ToString(buyDiff) + ")";
                    Session["BTCeBuyRate_BTC_Prev"] = buyRate;

                    if (buyDiff > 0)
                    {
                        BTCeBuyDiffLBL.ForeColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        BTCeBuyDiffLBL.ForeColor = System.Drawing.Color.Red;
                    }

                    BTCeBuyDiffLBL.Visible = true;
                }

                if (sellDiff != 0)
                {
                    BTCeSellDiffLBL.Text = "(" + Convert.ToString(sellDiff) + ")";
                    Session["BTCeSellRate_BTC_Prev"] = sellRate;

                    if (sellDiff > 0)
                    {
                        BTCeSellDiffLBL.ForeColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        BTCeSellDiffLBL.ForeColor = System.Drawing.Color.Red;
                    }

                    BTCeSellDiffLBL.Visible = true;
                } // if

            } // if
        }

        protected void Timer3_Tick(object sender, EventArgs e)
        {
            CoinBaseBuyLBL.Text = Convert.ToString(myCrypto.GetCoinbaseBuyRate_BTC()) + " USD";
            CoinbaseSellLBL.Text = Convert.ToString(myCrypto.GetCoinbaseSellRate_BTC()) + " USD";
        } // PopulateSellPrices
    }
}