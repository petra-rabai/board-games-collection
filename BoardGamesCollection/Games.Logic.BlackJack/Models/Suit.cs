namespace Games.BlackJack.Models;

public class Suit : ISuit
{
	public string[] Name { get; set; }
	public Card CardItem { get; set; }
}