using Infura.io.Api;
using Infura.io.Validation;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;

namespace Infura.io.Factories
{
    /// <seealso cref="IApiFactory" />
    public class ApiFactory : IApiFactory
    {
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        private readonly IHttpClientFactory _factory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiFactory"/> class using the DefaultHttpClientFactory. 
        /// </summary>
        public ApiFactory() : this(new DefaultHttpClientFactory())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiFactory"/> class.
        /// </summary>
        /// <param name="factory">The HttpClientFactory.</param>
        public ApiFactory([NotNull] IHttpClientFactory factory)
        {
            Check.NotNull(factory, nameof(factory));

            _factory = factory;
        }

        /// <seealso cref="IApiFactory.Create"/>
        public IInfuraApi Create(string endpoint)
        {
            Check.NotNullOrEmpty(endpoint, nameof(endpoint));

            var api = new RestClient(_factory.GetHttpClient())
            {
                JsonSerializerSettings = _serializerSettings
            }.For<IInfuraApi>();

            api.Endpoint = endpoint;

            return api;
        }
    }
}