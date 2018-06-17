using Infura.io.Api;

namespace Infura.io.Factories
{
    /// <summary>
    /// A factory to create the Infura API.
    /// </summary>
    public interface IApiFactory
    {
        /// <summary>
        /// Creates the Infura API client.
        /// </summary>
        /// <param name="endpoint">The Infura.io endpoint.</param>
        /// <returns><see cref = "IInfuraApi"/></returns >
        IInfuraApi Create(string endpoint);
    }
}