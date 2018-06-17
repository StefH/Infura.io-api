using RestEase;

namespace Infura.io.Api
{
    /// <summary>
    /// See https://infura.docs.apiary.io/api-description-document
    /// </summary>
    public interface IInfuraApi : IInfuraJSONRPCApi, IInfuraTickerApi
    {
        /// <summary>
        /// The infura.io endpoint.
        /// </summary>
        [Path("endpoint", UrlEncode = false)]
        string Endpoint { get; set; }
    }
}