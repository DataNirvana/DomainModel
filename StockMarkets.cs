using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class StockMarkets {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TnStocks = "Stock_Summary";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TnStockHistoryDaily = "Stock_Historic_Daily";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TnStockHistoryWeekly = "Stock_Historic_Weekly";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TnStockHistoryMonthly = "Stock_Historic_Monthly";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TnStockMarketGroups = "Stock_MarketGroups";


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //        string[] tickerFiles = { "AMS", "ASX", "BRU", "HKEX", "LIS", "LSE", "MLSE", "MSE", "NASDAQ", "NYSE", "NZX", "PAR", "SGX", "TSX" };
        /// 0 - Generic from the DB),
        /// 1 - Google (LGEN:LON),
        /// 2 - Bloomberg (LGEN:LN),
        /// 3 - Yahoo (LGEN.L),
        /// 4 - FT (LGEN:LSE) ....
        public static List<List<string>> MarketTickers = new List<List<string>>() {
            new List<string>() {"LSE", "LON", "LN", "L", "LSE" },
            new List<string>() {"NASDAQ", "NASDAQ", "US", "", "NSQ" },
            new List<string>() {"NYSE", "NYSE", "US", "", "NYQ" },
            new List<string>() {"SGX", "SGX", "SP", "SI", "SES" }
        };


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public StockMarkets() {

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// 0 - Generic from the DB),
        /// 1 - Google (LGEN:LON),
        /// 2 - Bloomberg (LGEN:LN),
        /// 3 - Yahoo (LGEN.L),
        /// 4 - FT (LGEN:LSE) ....
        /// </summary>
        public static string GetMarketCode(string genericCode, int specificMarket) {
            string marketCode = "";

            // get the market code ....
            if (genericCode != null && genericCode != "" && specificMarket >= 0 && specificMarket <= 4) {
                foreach (List<string> marketLK in StockMarkets.MarketTickers) {
                    if (genericCode.Equals(marketLK[0], StringComparison.CurrentCultureIgnoreCase)) {
                        marketCode = marketLK[specificMarket];
                    }
                }
            }

            return marketCode;
        }


    }
}
