using JetBrains.Annotations;

namespace Infura.io.Models
{
    /// <summary>
    /// JSON-RPC response
    /// </summary>
    [PublicAPI]
    public class JSONRPCResponse
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
        public string Jsonrpc { get; set; }

        /// <summary>
        /// JSON-RPC result (can also be an object)
        /// </summary>
        /// <value>JSON-RPC result (can also be an object)</value>
        public string Result { get; set; }

        /// <summary>
        /// JSON-RPC error object
        /// </summary>
        /// <value>The error</value>
        public JSONRPCError Error { get; set; }
    }
}