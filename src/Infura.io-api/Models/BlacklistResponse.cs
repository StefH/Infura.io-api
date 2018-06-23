using JetBrains.Annotations;

namespace Infura.io.Models
{
    /// <summary>
    /// Phishing blacklist, whitelist, and fuzzylist
    /// </summary>
    [PublicAPI]
    public class BlacklistResponse
    {
        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        public int Version { get; set; }

        /// <summary>
        /// Tolerance
        /// </summary>
        /// <value>Tolerance</value>
        public int Tolerance { get; set; }

        /// <summary>
        /// Fuzzylist
        /// </summary>
        /// <value>Fuzzylist</value>
        public string[] Fuzzylist { get; set; }

        /// <summary>
        /// Whitelist
        /// </summary>
        /// <value>Whitelist</value>
        public string[] Whitelist { get; set; }

        /// <summary>
        /// Blacklist
        /// </summary>
        /// <value>Blacklist</value>
        public string[] Blacklist { get; set; }
    }
}