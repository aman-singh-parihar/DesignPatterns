
//setup our DI
using Adapter;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<ExchangeRateManager>()
    .AddSingleton<IExchangeRate,ExchangeRate>()
    .AddSingleton<Client>()
    .BuildServiceProvider();

var client = serviceProvider.GetService<Client>();

Console.WriteLine("Please enter a number.");
var amount = Console.ReadLine();
var parsed = int.TryParse(amount, out var dollarAmount);

if (!parsed) 
{
    Console.WriteLine("It's not a valid number.");
    return;
}
    
var exchangedAmount = client.Execute(dollarAmount);
Console.WriteLine(exchangedAmount);