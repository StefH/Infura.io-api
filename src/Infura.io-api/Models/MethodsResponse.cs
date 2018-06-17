using System.Collections.Generic;
using Newtonsoft.Json;

namespace Infura.io.Models
{
    public class MethodsResponse
    {
        /// <summary>
        /// List of methods supported by the /v1/jsonrpc/{network}/{method} endpoint (GET)
        /// </summary>
        /// <value>List of methods supported by the /v1/jsonrpc/{network}/{method} endpoint (GET)</value>
        [JsonProperty(PropertyName = "get")]
        public List<string> Get { get; set; }

        /// <summary>
        /// List of methods supported by the /v1/jsonrpc/{network} endpoint (POST)
        /// </summary>
        /// <value>List of methods supported by the /v1/jsonrpc/{network} endpoint (POST)</value>
        [JsonProperty(PropertyName = "post")]
        public List<string> Post { get; set; }
    }
}