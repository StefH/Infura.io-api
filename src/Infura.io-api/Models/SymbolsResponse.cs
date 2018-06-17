using Newtonsoft.Json;

namespace Infura.io.Models
{
    public class SymbolsResponse
    {
        /// <summary>
        /// List of supported symbols (currency pairs)
        /// </summary>
        /// <value>List of supported symbols (currency pairs)</value>
        [JsonProperty(PropertyName = "symbols")]
        public string[] Symbols { get; set; }
    }
}
