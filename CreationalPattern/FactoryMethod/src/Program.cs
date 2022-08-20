using FactoryMethod;
using System;

var platinumCardFactory = new PlatinumCardFactory();
var card = platinumCardFactory.Card;

if (card != null)
{
    Console.Write("Invalid card.");
}
Console.WriteLine($"Name of the card:- {card.Name}");
Console.WriteLine($"Type of the card:- {card.Type}");
Console.WriteLine($"Limit of the card:- {card.Limit}");