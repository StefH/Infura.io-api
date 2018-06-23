using Infura.io.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infura.io.Models
{
    /// <summary>
    /// Regular JSON-RPC payload (POST body)
    /// </summary>
    [PublicAPI]
    public class JSONRPCRequest
    {
        /// <summary>
        /// JSON-RPC request ID
        /// </summary>
        /// <value>JSON-RPC request ID</value>
        public int Id { get; set; }

        /// <summary>
        /// JSON-RPC version
        /// </summary>
        /// <value>JSON-RPC version</value>
        public string Jsonrpc { get; } = "2.0";

        /// <summary>
        /// Ethereum JSON-RPC method. One of this list:
        /// - eth_sendRawTransaction
        /// - eth_estimateGas
        /// - eth_submitWork
        /// - eth_submitHashrate
        /// </summary>
        /// <value>Ethereum JSON-RPC method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public JSONRPCPostMethod Method { get; set; }

        /// <summary>
        /// JSON-RPC parameters (can be empty)
        /// </summary>
        /// <value>JSON-RPC parameters (can be empty)</value>
        public string[] Params { get; set; }
    }
}
