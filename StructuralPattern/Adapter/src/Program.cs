
//setup our DI
using Adapter;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<ExchangeRateManager>()
    .AddSingleton<IExchangeRate,ExchangeRate>()
    .AddSingleton<Client>()
    .BuildServiceProvider();

var client = serviceProvider.GetService<Client>();
client.Execute();