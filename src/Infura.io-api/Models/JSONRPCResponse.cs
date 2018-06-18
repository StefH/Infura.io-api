using Newtonsoft.Json;

namespace Infura.io.Models
{
    /// <summary>
    /// JSON-RPC response
    /// </summary>
    public class JSONRPCResponse
    {
        /// <summary>
        /// JSON-RPC request ID
        /// </summary>
        /// <value>JSON-RPC request ID</value>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// JSON-RPC version
        /// </summary>
        /// <value>JSON-RPC version</value>
        [JsonProperty(PropertyName = "jsonrpc")]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// JSON-RPC result (can also be an object)
        /// </summary>
        /// <value>JSON-RPC result (can also be an object)</value>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// JSON-RPC error object
        /// </summary>
        /// <value>The error</value>
        [JsonProperty(PropertyName = "error")]
        public JSONRPCError Error { get; set; }
    }
}