namespace Infura.io.Enums
{
    /// <summary>
    /// Ethereum network (in lowercase)
    /// </summary>
    public struct EthereumNetworkType
    {
        private readonly string _value;

        private EthereumNetworkType(string value) => _value = value;

        public override string ToString() => _value;

        public static EthereumNetworkType Mainnet { get; } = new EthereumNetworkType("mainnet");
        public static EthereumNetworkType Ropsten { get; } = new EthereumNetworkType("ropsten");
        public static EthereumNetworkType Kovan { get; } = new EthereumNetworkType("kovan");
        public static EthereumNetworkType Rinkeby { get; } = new EthereumNetworkType("rinkeby");
    }
}