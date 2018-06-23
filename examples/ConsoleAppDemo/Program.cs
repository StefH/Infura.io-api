using System;
using System.Threading.Tasks;
using Infura.io.Api;
using Infura.io.Enums;
using Infura.io.Factories;
using Infura.io.Models;
using Newtonsoft.Json;

namespace ConsoleAppDemo
{
    class Program
    {
        private static readonly string endpoint = "https://api.infura.io";

        static void Main()
        {
            TestApi().Wait(30000);
        }

        private static async Task TestApi()
        {
            IApiFactory factory = new ApiFactory();

            IInfuraApi api = factory.Create(endpoint);

            var symbolsResponse = await api.GetSymbolsAsync();
            Console.WriteLine("GetSymbolsAsync = " + JsonConvert.SerializeObject(symbolsResponse, Formatting.Indented));

            var symbolResponse = await api.GetSymbolAsync("ethadt");
            Console.WriteLine("GetSymbolAsync = " + JsonConvert.SerializeObject(symbolResponse, Formatting.Indented));

            var full = await api.GetSymbolsFullAsync("ethadt");
            Console.WriteLine("GetSymbolsFullAsync = " + JsonConvert.SerializeObject(full, Formatting.Indented));

            var blacklistedSites = await api.GetBlacklistedDomainsAsync();
            Console.WriteLine("GetBlacklistedDomainsAsync = " + JsonConvert.SerializeObject(blacklistedSites, Formatting.Indented));

            var blacklistResponse = await api.GetBlacklistAsync();
            Console.WriteLine("GetBlacklistAsync = " + JsonConvert.SerializeObject(blacklistResponse, Formatting.Indented));

            var methodsResponse = await api.GetMethodsAsync(EthereumNetworkType.Rinkeby);
            Console.WriteLine("GetMethodsAsync = " + JsonConvert.SerializeObject(methodsResponse, Formatting.Indented));

            var jsonrpcResponse = await api.GetMethodAsync(EthereumNetworkType.Rinkeby, "web3_clientVersion");
            Console.WriteLine("GetMethodAsync = " + JsonConvert.SerializeObject(jsonrpcResponse, Formatting.Indented));

            var requestEstimateGas = new JSONRPCRequest
            {
                Id = 42,
                Method = JSONRPCPostMethod.EstimateGas
            };

            var postResult = await api.PostRequestAsync(EthereumNetworkType.Rinkeby, requestEstimateGas);
            Console.WriteLine("PostRequestAsync = " + JsonConvert.SerializeObject(postResult, Formatting.Indented));
        }
    }
}