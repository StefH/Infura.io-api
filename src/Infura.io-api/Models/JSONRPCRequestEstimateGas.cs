namespace Infura.io.Models
{
    // ReSharper disable once InconsistentNaming
    public class JSONRPCRequestEstimateGas : JSONRPCRequest
    {
        public override string Method { get; } = "eth_estimateGas";
    }
}