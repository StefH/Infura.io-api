using System.Net.Http;
using JetBrains.Annotations;

namespace Infura.io.Factories
{
    /// <summary>
    /// Factory to create a HttpClient.
    /// </summary>
    [PublicAPI]
    public interface IHttpClientFactory
    {
        /// <summary>
        /// Gets the HTTP client.
        /// </summary>
        /// <returns></returns>
        HttpClient GetHttpClient();
    }
}