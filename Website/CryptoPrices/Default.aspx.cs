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
                
            }
            else
            {

            }

            // Populate current buy prices.
            PopulateBuyPrices();

            // Populate current sell prices.
            PopulateSellPrices();
            
        } // Page_Load

        protected void PopulateBuyPrices()
        {
            // Populate the labels with the current buy prices.
            CoinBaseBuyLBL.Text = Convert.ToString(myCrypto.GetCoinbaseBuyRate_BTC()) + " USD";
            MtGoxBuyLBL.Text = Convert.ToString(myCrypto.GetMtGoxBuyRate_BTC()) + " USD";
            
        } // PopulateBuyPrices

        protected void PopulateSellPrices()
        {
            // Populate the labels with the current sell prices.
            CoinbaseSellLBL.Text = Convert.ToString(myCrypto.GetCoinbaseSellRate_BTC()) + " USD";
            MtGoxSellLBL.Text = Convert.ToString(myCrypto.GetMtGoxSellRate_BTC()) + " USD";

        } // PopulateSellPrices
    }
}