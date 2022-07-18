namespace Games.BlackJack.Models;

public class Card : ICard
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Suit { get; set; }
	public int Value { get; set; }
}