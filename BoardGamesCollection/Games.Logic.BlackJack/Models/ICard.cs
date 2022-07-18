namespace Games.BlackJack.Models;

public interface ICard
{
	int Id { get; set; }
	string Name { get; set; }
	string Suit { get; set; }
	int Value { get; set; }
}