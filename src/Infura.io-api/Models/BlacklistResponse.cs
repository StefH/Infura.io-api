using Newtonsoft.Json;

namespace Infura.io.Models
{
    /// <summary>
    /// Phishing blacklist, whitelist, and fuzzylist
    /// </summary>
    public class BlacklistResponse
    {
        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [JsonProperty(PropertyName = "version")]
        public int Version { get; set; }

        /// <summary>
        /// Tolerance
        /// </summary>
        /// <value>Tolerance</value>
        [JsonProperty(PropertyName = "tolerance")]
        public int Tolerance { get; set; }

        /// <summary>
        /// Fuzzylist
        /// </summary>
        /// <value>Fuzzylist</value>
        [JsonProperty(PropertyName = "fuzzylist")]
        public string[] Fuzzylist { get; set; }

        /// <summary>
        /// Whitelist
        /// </summary>
        /// <value>Whitelist</value>
        [JsonProperty(PropertyName = "whitelist")]
        public string[] Whitelist { get; set; }

        /// <summary>
        /// Blacklist
        /// </summary>
        /// <value>Blacklist</value>
        [JsonProperty(PropertyName = "blacklist")]
        public string[] Blacklist { get; set; }
    }
}