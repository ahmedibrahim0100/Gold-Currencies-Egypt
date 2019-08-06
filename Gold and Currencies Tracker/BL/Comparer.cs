using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gold_and_Currencies_Tracker.BL
{
    class Comparer
    {
        //YTPZLCAIKFTJSQVT --- This is API Key for Alpha vantage for exchange rates
        //US Dollar to Japanese Yen:
        //https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=USD&to_currency=JPY&apikey=demo

        public List<string> GetRate(string from, string to)
        {
            WebClient web = new WebClient();

            string url = string.Format("https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={0}&to_currency={1}&apikey=YTPZLCAIKFTJSQVT", from.ToUpper(), to.ToUpper());

            string response = web.DownloadString(url);

            RootObject obj = JsonConvert.DeserializeObject<RootObject>(response);

            string exchangeRate = obj.Realtime_Currency_Exchange_Rate.Exchange_Rate;
            string lastRefreshed = obj.Realtime_Currency_Exchange_Rate.Last_Refreshed;
            string timeZone = obj.Realtime_Currency_Exchange_Rate.Time_Zone;
            string bidPrice = obj.Realtime_Currency_Exchange_Rate.Bid_Price;
            string askPrice = obj.Realtime_Currency_Exchange_Rate.Ask_Price;

            return new List<string> { exchangeRate, lastRefreshed, timeZone, bidPrice, askPrice };
        }

    }
}
