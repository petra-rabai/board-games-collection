namespace Games.BlackJack.Models;

public interface ISuit
{
	string[] Name { get; set; }
	Card CardItem { get; set; }
}