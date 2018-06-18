using System.Threading.Tasks;
using Infura.io.Models;
using JetBrains.Annotations;
using RestEase;

namespace Infura.io.Api
{
    public interface IInfuraTickerApi
    {
        /// <summary>
        /// Get a list of supported symbols (currency pairs), including fiat, crypto, and tokens.
        /// </summary>
        /// <returns><see cref="SymbolsResponse"/></returns>
        [Get("{endpoint}/v1/ticker/symbols")]
        [PublicAPI]
        Task<SymbolsResponse> GetSymbolsAsync();

        /// <summary>
        /// Get pricing (ticker) data for various currency pairs (fiat, crypto, and tokens) using data from several exchanges.
        /// This endpoint shows the price at the exchange with the most volume for the symbol.
        /// </summary>
        /// <param name="symbol">Ticker symbol (currency pair).</param>
        /// <returns><see cref="TickerResponse"/></returns>
        [Get("{endpoint}/v1/ticker/{symbol}")]
        [PublicAPI]
        Task<TickerResponse> GetSymbolAsync([Path] string symbol);

        /// <summary>
        /// Get pricing (ticker) data for various currency pairs (fiat, crypto, and tokens) using data from several exchanges.
        /// This endpoint shows the price at various exchanges where the symbol is traded. 
        /// </summary>
        /// <param name="symbol">Ticker symbol (currency pair).</param>
        /// <returns><see cref="TickerResponse"/></returns>
        [Get("{endpoint}/v1/ticker/{symbol}/full")]
        [PublicAPI]
        Task<TickerFullResponse> GetSymbolsFullAsync([Path] string symbol);
    }
}
