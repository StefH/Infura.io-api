using System.Threading.Tasks;
using Infura.io.Models;
using JetBrains.Annotations;
using RestEase;

namespace Infura.io.Api
{
    public interface IInfuraBlacklistApi
    {
        /// <summary>
        /// Return a blacklist of phishing sites.
        /// This list is maintained by GitHub user 409H at https://github.com/409H/EtherAddressLookup/blob/master/blacklists/domains.json.
        /// </summary>
        /// <returns>List of blacklisted phishing domains.</returns>
        [Get("{endpoint}/v1/blacklist")]
        [PublicAPI]
        Task<string[]> GetBlacklistedDomainsAsync();

        /// <summary>
        /// Return a blacklist of phishing sites, as well as a whitelist and a fuzzylist.
        /// This list is maintained by the MetaMask project at https://github.com/MetaMask/eth-phishing-detect/blob/master/src/config.json.
        /// </summary>
        /// <returns><see cref="BlacklistResponse"/></returns>
        [Get("{endpoint}/v2/blacklist")]
        [PublicAPI]
        Task<BlacklistResponse> GetBlacklistAsync();
    }
}