# ![Project Icon](resources\infura.io_32x32.png) Infura.io API
Infura.io C# API which uses [RestEase](https://github.com/canton7/RestEase) to generate an API interface for the [Infura API](https://infura.docs.apiary.io/api-description-document).

### Methods

The following **jsonrpc** calls are implemented:
- GET `/v1/jsonrpc/{network}/methods`
- GET `/v1/jsonrpc/{network}/{method}`
- POST `/v1/jsonrpc/{network}`

The following **ticker** calls are implemented:
- GET `/v1/ticker/symbols`
- GET `/v1/ticker/{symbol}`
- GET `/v1/ticker/{symbol}/full`

The following **blacklist** calls are implemented:
- GET `/v1/blacklist`
- GET `/v2/blacklist`

### NuGet

| Name | NuGet |
| ---- | ----- |
| Infura.io-api | [![NuGet Badge](https://buildstats.info/nuget/Infura.io-api)](https://www.nuget.org/packages/Infura.io-api) |

### Frameworks
The following frameworks are supported:
- net 4.5
- net 4.6
- netstandard 1.1
- netstandard 2.0


### Usage example for Infura.io Api

``` c#
IApiFactory factory = new ApiFactory();

var api = factory.Create(endpoint);

var methodsResponse = await api.GetMethodsAsync(EthereumNetworkType.rinkeby);
Console.WriteLine("GetMethodsAsync = " + JsonConvert.SerializeObject(methodsResponse, Formatting.Indented));
```

For more examples, see [ConsoleAppDemo/Program.cs](https://github.com/StefH/Infura.io-api/blob/master/examples/ConsoleAppDemo/Program.cs).

