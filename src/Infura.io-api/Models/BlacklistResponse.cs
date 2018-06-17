using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Infura.io.Models {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BlacklistResponse {
    /// <summary>
    /// Version
    /// </summary>
    /// <value>Version</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// Tolerance
    /// </summary>
    /// <value>Tolerance</value>
    [DataMember(Name="tolerance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tolerance")]
    public int? Tolerance { get; set; }

    /// <summary>
    /// Fuzzylist
    /// </summary>
    /// <value>Fuzzylist</value>
    [DataMember(Name="fuzzylist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuzzylist")]
    public List<string> Fuzzylist { get; set; }

    /// <summary>
    /// Whitelist
    /// </summary>
    /// <value>Whitelist</value>
    [DataMember(Name="whitelist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "whitelist")]
    public List<string> Whitelist { get; set; }

    /// <summary>
    /// Blacklist
    /// </summary>
    /// <value>Blacklist</value>
    [DataMember(Name="blacklist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blacklist")]
    public List<string> Blacklist { get; set; }



}
}
