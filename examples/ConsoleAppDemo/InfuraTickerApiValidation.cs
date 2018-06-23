using System;
using System.Threading.Tasks;
using Infura.io.Api;
using Infura.io.Models;

namespace ConsoleAppDemo
{
    public class InfuraTickerApiValidation : IInfuraTickerApi
    {
        public Task<TickerResponse> GetSymbolAsync(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
            {
                throw new ArgumentNullException(nameof(symbol));
            }

            return null;
        }

        public Task<SymbolsResponse> GetSymbolsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TickerFullResponse> GetSymbolsFullAsync(string symbol)
        {
            throw new NotImplementedException();
        }
    }
}
