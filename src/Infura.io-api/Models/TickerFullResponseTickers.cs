using Newtonsoft.Json;

namespace Infura.io.Models
{
    public class TickerFullResponseTickers
    {
        /// <summary>
        /// Bid
        /// </summary>
        /// <value>Bid</value>
        [JsonProperty(PropertyName = "bid")]
        public decimal? Bid { get; set; }

        /// <summary>
        /// Ask
        /// </summary>
        /// <value>Ask</value>
        [JsonProperty(PropertyName = "ask")]
        public decimal? Ask { get; set; }

        /// <summary>
        /// Exchange
        /// </summary>
        /// <value>Exchange</value>
        [JsonProperty(PropertyName = "exchange")]
        public string Exchange { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        /// <value>Volume</value>
        [JsonProperty(PropertyName = "volume")]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Unix timestamp
        /// </summary>
        /// <value>Unix timestamp</value>
        [JsonProperty(PropertyName = "timestamp")]
        public int? Timestamp { get; set; }
    }
}