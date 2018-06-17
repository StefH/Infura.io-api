using Newtonsoft.Json;

namespace Infura.io.Models
{
    public class TickerResponse
    {
        /// <summary>
        /// Currency pair base
        /// </summary>
        /// <value>Currency pair base</value>
        [JsonProperty(PropertyName = "base")]
        public string Base { get; set; }

        /// <summary>
        /// Currency pair quote
        /// </summary>
        /// <value>Currency pair quote</value>
        [JsonProperty(PropertyName = "quote")]
        public string Quote { get; set; }

        /// <summary>
        /// Bid at the exchange with the most volume
        /// </summary>
        /// <value>Bid at the exchange with the most volume</value>
        [JsonProperty(PropertyName = "bid")]
        public decimal? Bid { get; set; }

        /// <summary>
        /// Ask at the exchange with the most volume
        /// </summary>
        /// <value>Ask at the exchange with the most volume</value>
        [JsonProperty(PropertyName = "ask")]
        public decimal? Ask { get; set; }

        /// <summary>
        /// The exchange with the most volume
        /// </summary>
        /// <value>The exchange with the most volume</value>
        [JsonProperty(PropertyName = "exchange")]
        public string Exchange { get; set; }

        /// <summary>
        /// Volume at the exchange with the most volume
        /// </summary>
        /// <value>Volume at the exchange with the most volume</value>
        [JsonProperty(PropertyName = "volume")]
        public decimal? Volume { get; set; }

        /// <summary>
        /// Number of exchanges queried
        /// </summary>
        /// <value>Number of exchanges queried</value>
        [JsonProperty(PropertyName = "num_exchanges")]
        public int? NumExchanges { get; set; }

        /// <summary>
        /// Total volume across all exchanges queried
        /// </summary>
        /// <value>Total volume across all exchanges queried</value>
        [JsonProperty(PropertyName = "total_volume")]
        public decimal? TotalVolume { get; set; }

        /// <summary>
        /// Unix timestamp
        /// </summary>
        /// <value>Unix timestamp</value>
        [JsonProperty(PropertyName = "timestamp")]
        public int? Timestamp { get; set; }
    }
}