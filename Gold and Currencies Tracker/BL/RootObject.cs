using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_and_Currencies_Tracker.BL
{
    class RootObject
    {
        [JsonProperty("Realtime Currency Exchange Rate")]
        public Realtime_Currency_Exchange_Rate Realtime_Currency_Exchange_Rate { get; set; }
    }

    class Realtime_Currency_Exchange_Rate
    {
        [JsonProperty("1. From_Currency Code")]
        public string From_Currency_Code { get; set; }

        [JsonProperty("2. From_Currency Name")]
        public string From_Currency_Name { get; set; }

        [JsonProperty("3. To_Currency Code")]
        public string To_Currency_Code { get; set; }

        [JsonProperty("4. To_Currency Name")]
        public string To_Currency_Name { get; set; }

        [JsonProperty("5. Exchange Rate")]
        public string Exchange_Rate { get; set; }

        [JsonProperty("6. Last Refreshed")]
        public string Last_Refreshed { get; set; }

        [JsonProperty("7. Time Zone")]
        public string Time_Zone { get; set; }

        [JsonProperty("8. Bid Price")]
        public string Bid_Price { get; set; }

        [JsonProperty("9. Ask Price")]
        public string Ask_Price { get; set; }
    }
}
