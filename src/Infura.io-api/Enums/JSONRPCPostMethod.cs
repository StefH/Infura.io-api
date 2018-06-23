using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace Infura.io.Enums
{
    /// <summary>
    /// Ethereum JSON-RPC POST method
    /// </summary>
    [PublicAPI]
    public enum JSONRPCPostMethod
    {
        [EnumMember(Value = "eth_estimateGas")]
        EstimateGas,

        [EnumMember(Value = "eth_sendRawTransaction")]
        SendRawTransaction,

        [EnumMember(Value = "eth_submitHashrate")]
        SubmitHashrate,

        [EnumMember(Value = "eth_submitWork")]
        SubmitWork
    }
}