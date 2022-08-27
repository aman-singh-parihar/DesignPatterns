using FactoryMethod;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var platinumCardFactory = new PlatinumCardFactory();
var card = platinumCardFactory.Card;
//var card = platinumCardFactory.CreateCard();


if (card != null)
{
    Console.Write("Invalid card.");
}
Console.WriteLine($"Name of the card:- {card.Name}");
Console.WriteLine($"Type of the card:- {card.Type}");
Console.WriteLine($"Limit of the card:- {card.Limit}");
//setup our DI
var serviceProvider = new ServiceCollection()
    .AddLogging()
    .AddSingleton<IFooService, FooService>()
    .AddSingleton<BarService>()
    .BuildServiceProvider();

var bar = serviceProvider.GetService<BarService>();
bar.DoSomeRealWork();

public interface IFooService
{
    void DoThing(int number);
}

public interface IBarService
{
    void DoSomeRealWork();
}

public class BarService //: IBarService
{
    private readonly IFooService _fooService;
    public BarService(IFooService fooService)
    {
        _fooService = fooService;
    }

    public void DoSomeRealWork()
    {
        for (int i = 0; i < 10; i++)
        {
            _fooService.DoThing(i);
        }
    }
}

public class FooService : IFooService
{
    public void DoThing(int number)
    {
        Console.WriteLine($"Doing the thing {number}");
    }
}

