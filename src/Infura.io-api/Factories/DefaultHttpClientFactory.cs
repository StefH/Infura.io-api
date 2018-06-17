using System.Net.Http;

namespace Infura.io.Factories
{
    /// <seealso cref="IHttpClientFactory" />
    internal class DefaultHttpClientFactory : IHttpClientFactory
    {
        /// <summary>
        /// Always return the same static HttpClient. See https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/
        /// </summary>
        private static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// Gets the HTTP client.
        /// </summary>
        /// <returns></returns>
        public HttpClient GetHttpClient()
        {
            return Client;
        }
    }
}