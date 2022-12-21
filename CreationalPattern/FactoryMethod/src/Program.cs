using FactoryMethod;

var client = new Client(new PlatinumCardFactory());
var card = client.GetCard();

if (card != null)
{
    Console.Write("Invalid card.");
}
Console.WriteLine($"Name of the card:- {card.Name}");
Console.WriteLine($"Type of the card:- {card.Type}");
Console.WriteLine($"Limit of the card:- {card.Limit}");


