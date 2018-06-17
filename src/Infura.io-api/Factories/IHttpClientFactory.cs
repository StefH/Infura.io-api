using System.Net.Http;

namespace Infura.io.Factories
{
    /// <summary>
    /// Factory to create a HttpClient.
    /// </summary>
    public interface IHttpClientFactory
    {
        /// <summary>
        /// Gets the HTTP client.
        /// </summary>
        /// <returns></returns>
        HttpClient GetHttpClient();
    }
}