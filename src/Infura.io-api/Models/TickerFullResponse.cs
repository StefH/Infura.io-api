using System.Collections.Generic;
using JetBrains.Annotations;

namespace Infura.io.Models
{
    /// <summary>
    /// Full ticker response
    /// </summary>
    [PublicAPI]
    public class TickerFullResponse
    {
        /// <summary>
        /// Currency pair base
        /// </summary>
        /// <value>Currency pair base</value>
        public string Base { get; set; }

        /// <summary>
        /// Currency pair quote
        /// </summary>
        /// <value>Currency pair quote</value>
        public string Quote { get; set; }

        /// <summary>
        /// List of tickers at various exchanges
        /// </summary>
        /// <value>List of tickers at various exchanges</value>
        public List<TickerFullResponseTickers> Tickers { get; set; }
    }
}