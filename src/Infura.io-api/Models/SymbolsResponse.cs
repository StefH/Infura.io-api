using JetBrains.Annotations;

namespace Infura.io.Models
{
    [PublicAPI]
    public class SymbolsResponse
    {
        /// <summary>
        /// List of supported symbols (currency pairs)
        /// </summary>
        /// <value>List of supported symbols (currency pairs)</value>
        public string[] Symbols { get; set; }
    }
}
