using System;
using System.Threading.Tasks;
using Infura.io.Enums;
using Infura.io.Factories;
using Newtonsoft.Json;

namespace ConsoleAppDemo
{
    class Program
    {
        private static readonly string endpoint = "https://api.infura.io";

        static void Main(string[] args)
        {
            TestApi().Wait(30000);
        }

        private static async Task TestApi()
        {
            IApiFactory factory = new ApiFactory();

            var api = factory.Create(endpoint);

            var methodsResponse = await api.GetMethodsAsync(EthereumNetworkType.rinkeby);
            Console.WriteLine("GetMethodsAsync=" + JsonConvert.SerializeObject(methodsResponse, Formatting.Indented));

            var jsonrpcResponse = await api.GetMethodAsync(EthereumNetworkType.rinkeby, "web3_clientVersion");
            Console.WriteLine("GetMethodAsync=" + JsonConvert.SerializeObject(jsonrpcResponse, Formatting.Indented));

            //var requestEstimateGas = new JSONRPCRequestEstimateGas
            //{
            //    Id = 1
            //};
            //Console.WriteLine("JSONRPCRequestEstimateGas=" + JsonConvert.SerializeObject(requestEstimateGas, new JsonSerializerSettings
            //{
            //    NullValueHandling = NullValueHandling.Ignore,
            //    Formatting = Formatting.Indented
            //}));

            //var postResult = await api.PostRequestAsync(EthereumNetworkType.rinkeby, requestEstimateGas);
            //Console.WriteLine("PostRequestAsync=" + JsonConvert.SerializeObject(postResult, Formatting.Indented));

            var symbolsResponse = await api.GetSymbolsAsync();
            Console.WriteLine("GetSymbolsAsync=" + JsonConvert.SerializeObject(symbolsResponse, Formatting.Indented));

            var symbolResponse = await api.GetSymbolAsync("ethadt");
            Console.WriteLine("GetSymbolAsync=" + JsonConvert.SerializeObject(symbolResponse, Formatting.Indented));

            var full = await api.GetSymbolsFullAsync("ethadt");
            Console.WriteLine("GetSymbolsFullAsync=" + JsonConvert.SerializeObject(symbolResponse, Formatting.Indented));

            // todo more methods...
        }
    }
}