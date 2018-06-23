using System.Threading.Tasks;
using Infura.io.Enums;
using Infura.io.Models;
using JetBrains.Annotations;
using RestEase;

namespace Infura.io.Api
{
    public interface IInfuraJSONRPCApi
    {
        /// <summary>
        /// The JSON-RPC methods supported by the `/v1/jsonrpc/{network}/{method}` (GET) and `/v1/jsonrpc/{network}` (POST) endpoints.
        /// </summary>
        /// <param name="network">The Ethereum network.</param>
        /// <returns><see cref="MethodsResponse"/></returns>
        [Get("{endpoint}/v1/jsonrpc/{network}/methods")]
        [PublicAPI]
        Task<MethodsResponse> GetMethodsAsync([Path] EthereumNetworkType network);

        /// <summary>
        /// A request using an "HTTP GET-compatible" (non-state-changing) JSON-RPC method.
        /// Most Ethereum JSON-RPC methods can be described in this way, since they query the blockchain for various pieces of information.
        /// </summary>
        /// <param name="network">The Ethereum network.</param>
        /// <param name="method">JSON-RPC method. Use the `/v1/jsonrpc/{network}/methods` endpoint to get the list of permitted methods.</param>
        /// <returns><see cref="JSONRPCResponse"/></returns>
        [Get("{endpoint}/v1/jsonrpc/{network}/{method}")]
        [PublicAPI]
        Task<JSONRPCResponse> GetMethodAsync([Path] EthereumNetworkType network, [NotNull, Path] string method);

        /// <summary>
        /// A request using an "HTTP POST-compatible" (state-changing) JSON-RPC method.
        /// </summary>
        /// <param name="network">The Ethereum network.</param>
        /// <param name="request">Regular JSON-RPC payload (POST body).</param>
        /// <returns><see cref="JSONRPCResponse"/></returns>
        [Post("{endpoint}/v1/jsonrpc/{network}")]
        [Header("Content-Type", "application/json")]
        [Header("Accept", "application/json")]
        [PublicAPI]
        Task<JSONRPCResponse> PostRequestAsync([Path] EthereumNetworkType network, [Body] JSONRPCRequest request);
    }
}