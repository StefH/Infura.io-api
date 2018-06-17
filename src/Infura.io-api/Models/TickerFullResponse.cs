using System.Collections.Generic;
using Newtonsoft.Json;

namespace Infura.io.Models
{
    /// <summary>
    /// Full ticker response
    /// </summary>
    public class TickerFullResponse
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
        /// List of tickers at various exchanges
        /// </summary>
        /// <value>List of tickers at various exchanges</value>
        [JsonProperty(PropertyName = "tickers")]
        public List<TickerFullResponseTickers> Tickers { get; set; }
    }
}