using JetBrains.Annotations;

namespace Infura.io.Models
{
    [PublicAPI]
    public class TickerFullResponseTickers
    {
        /// <summary>
        /// Bid
        /// </summary>
        /// <value>Bid</value>
        public decimal Bid { get; set; }

        /// <summary>
        /// Ask
        /// </summary>
        /// <value>Ask</value>
        public decimal Ask { get; set; }

        /// <summary>
        /// Exchange
        /// </summary>
        /// <value>Exchange</value>
        public string Exchange { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        /// <value>Volume</value>
        public decimal Volume { get; set; }

        /// <summary>
        /// Unix timestamp
        /// </summary>
        /// <value>Unix timestamp</value>
        public int Timestamp { get; set; }
    }
}