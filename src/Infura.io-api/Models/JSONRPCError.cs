using JetBrains.Annotations;

namespace Infura.io.Models
{
    /// <summary>
    /// In case of an error
    /// </summary>
    [PublicAPI]
    public class JSONRPCError
    {
        public int Code { get; set; }

        public string Message { get; set; }
    }
}