using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Infura.io.Models
{
    /// <summary>
    /// In case of an error
    /// </summary>
    [PublicAPI]
    public class JSONRPCError
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}