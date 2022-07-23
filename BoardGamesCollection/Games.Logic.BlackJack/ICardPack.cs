using Games.BlackJack.Models;

namespace Games.BlackJack;

public interface ICardPack
{
	Card[] Cards { get; set; }
	Card[] GetCardPack();
}