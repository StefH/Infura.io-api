using System.Collections.Generic;
using JetBrains.Annotations;

namespace Infura.io.Models
{
    [PublicAPI]
    public class MethodsResponse
    {
        /// <summary>
        /// List of methods supported by the /v1/jsonrpc/{network}/{method} endpoint (GET)
        /// </summary>
        /// <value>List of methods supported by the /v1/jsonrpc/{network}/{method} endpoint (GET)</value>
        public List<string> Get { get; set; }

        /// <summary>
        /// List of methods supported by the /v1/jsonrpc/{network} endpoint (POST)
        /// </summary>
        /// <value>List of methods supported by the /v1/jsonrpc/{network} endpoint (POST)</value>
        public List<string> Post { get; set; }
    }
}