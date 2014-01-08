<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CryptoPrices.Default" %>

<!doctype html>
<html>
<head>
    <title>CryptoPrices</title>
    <meta name="viewport" content="width=device-width">
    <link href="Styles/bootstrap.min.css" rel="stylesheet" />
    <%-- <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"/> --%>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js" type="text/javascript"></script>

    <script src="Styles/bootstrap.min.js" type="text/javascript"></script>
    <%-- <script src="https://netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js" type="text/javascript"></script> --%>
    <style type="text/css">
        /*
       * Style tweaks
       * --------------------------------------------------
       */
        body {
            padding-top: 70px;
        }

        footer {
            padding-left: 15px;
            padding-right: 15px;
        }

        /*
       * Off Canvas
       * --------------------------------------------------
       */
        @media screen and (max-width: 768px) {
            .row-offcanvas {
                position: relative;
                -webkit-transition: all 0.25s ease-out;
                -moz-transition: all 0.25s ease-out;
                transition: all 0.25s ease-out;
            }

            .row-offcanvas-right .sidebar-offcanvas {
                right: -50%; /* 6 columns */
            }

            .row-offcanvas-left .sidebar-offcanvas {
                left: -50%; /* 6 columns */
            }

            .row-offcanvas-right.active {
                right: 50%; /* 6 columns */
            }

            .row-offcanvas-left.active {
                left: 50%; /* 6 columns */
            }

            .sidebar-offcanvas {
                position: absolute;
                top: 0;
                width: 50%; /* 6 columns */
            }
        }
    </style>
</head>
<body>
    <form runat="server" id="form1">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="navbar navbar-fixed-top navbar-inverse" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand">Markets</a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">BTC</a></li>
                        <li><a href="#">LTC</a></li>
                        <li><a href="#">PPC</a></li>
                        <li><a href="#">NMC</a></li>
                        <li><a href="#">WDC</a></li>
                        <li><a href="#">XPM</a></li>
                        <li><a href="#">PTS</a></li>
                        <li><a href="#">More...</a></li>
                    </ul>
                </div>
                <!-- /.nav-collapse -->
            </div>
            <!-- /.container -->
        </div>
        <!-- /.navbar -->

        <div class="container">

            <div class="row row-offcanvas row-offcanvas-right">
                <div class="col-xs-12 col-sm-9">
                    <p class="pull-right visible-xs">
                        <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
                    </p>
                    <div class="jumbotron">
                        <h1>Hello, world!</h1>
                        <p>This is an example to show the potential of an offcanvas layout pattern in Bootstrap. Try some responsive-range viewport sizes to see it in action.</p>
                    </div>

                    <%-- INDIVIDUAL WEBSITE PRICES --%>
                    <div class="row">
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>Mt.Gox</h2>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Timer runat="server" Interval="5000" ID="Timer1" OnTick="Timer1_Tick"></asp:Timer>

                                    <asp:Table ID="Table1" runat="server">

                                        <%-- Buy --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Buy:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="MtGoxBuyLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell ID="MtGoxBuyDiffLBL" runat="server" Visible="false">
                                                <%-- FILLED PROGRAMATICALLY --%>
                                            </asp:TableCell>
                                        </asp:TableRow>

                                        <%-- Sell --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Sell:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="MtGoxSellLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell ID="MtGoxSellDiffLBL" runat="server" Visible="false">
                                                <%-- FILLED PROGRAMATICALLY --%>
                                            </asp:TableCell>
                                        </asp:TableRow>

                                    </asp:Table>
                                </ContentTemplate>
                            </asp:UpdatePanel>


                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>BTCe</h2>

                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Timer runat="server" Interval="5000" ID="Timer2" OnTick="Timer2_Tick"></asp:Timer>

                                    <asp:Table ID="Table2" runat="server">

                                        <%-- Buy --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Buy:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="BTCeBuyLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell ID="BTCeBuyDiffLBL" runat="server" Visible="false">
                                                <%-- FILLED PROGRAMATICALLY --%>
                                            </asp:TableCell>
                                        </asp:TableRow>

                                        <%-- Sell --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Sell:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="BTCeSellLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                            <asp:TableCell ID="BTCeSellDiffLBL" runat="server" Visible="false">
                                                <%-- FILLED PROGRAMATICALLY --%>
                                            </asp:TableCell>
                                        </asp:TableRow>

                                    </asp:Table>

                                </ContentTemplate>
                            </asp:UpdatePanel>


                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>Coinbase</h2>

                            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Timer runat="server" ID="Timer3" Interval="5000" OnTick="Timer3_Tick"></asp:Timer>

                                    <asp:Table runat="server" ID="Table3">

                                        <%-- Buy --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Buy:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="CoinBaseBuyLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                        </asp:TableRow>

                                        <%-- Sell --%>
                                        <asp:TableRow>
                                            <asp:TableCell>
                                                Sell:
                                            </asp:TableCell>
                                            <asp:TableCell>
                                                <asp:Label ID="CoinbaseSellLBL" runat="server" Text="$0.00"></asp:Label>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>Bitstamp</h2>
 
                            <asp:UpdatePanel runat="server">

                            </asp:UpdatePanel>                           

                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>BTCChina</h2>
                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                        <div class="col-6 col-sm-6 col-lg-4">
                            <h2>Kraken</h2>
                            <p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>
                            <p><a class="btn btn-default" href="#">View details &raquo;</a></p>
                        </div>
                        <!--/span-->
                    </div>
                    <!--/row-->
                </div>
                <!--/span-->



                <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar" role="navigation">
                    <asp:Panel runat="server" ID="SidebarPanelNav" CssClass="well sidebar-nav">
                        <ul class="nav">
                            <%-- Charts --%>
                            <li><asp:Label ID="ChartLinksLBL" runat="server" Font-Bold="true" Text="Charts"></asp:Label></li>
                            <li><a href="http://www.cryptocoincharts.info/v2/main/smallCharts" target="_blank">CryptoCoinCharts v2</a></li>
                            <li><a href="http://www.bitcoinwisdom.com" target="_blank">BitcoinWisdom</a></li>
                            <li><a href="http://bitcoinity.org/markets" target="_blank">Bitcoinity</a></li>

                            <%-- Listen --%>
                            <li><asp:Label ID="ListenLBL" runat="server" Text="Listen" Font-Bold="true"></asp:Label></li>
                            <li><a href="http://letstalkbitcoin.com/" target="_blank">Let's Talk Bitcoin</a></li>

                            <%-- Read --%>
                            <li><asp:Label ID="ReadLBL" runat="server" Text="Read" Font-Bold="true"></asp:Label></li>
                            <li><a href="http://www.reddit.com/r/Bitcoin" target="_blank">r/Bitcoin Subreddit</a></li>
                            <li><a href="http://www.bitcointalk.org" target="_blank">Bitcoin Talk Forum</a></li>
                        </ul>
                    </asp:Panel>
                </div>

                <!--/span-->
            </div>
            <!--/row-->

            <hr>

            <footer>
                <p>&copy; CryptoPrices.net 2014</p>
            </footer>

        </div>
        <!--/.container-->
        <script>
            $(document).ready(function () {
                $('[data-toggle=offcanvas]').click(function () {
                    $('.row-offcanvas').toggleClass('active');
                });
            });
        </script>

    </form>
</body>
</html>
