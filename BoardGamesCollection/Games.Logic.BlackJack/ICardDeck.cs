using Games.BlackJack.Models;

namespace Games.BlackJack;

public interface ICardDeck
{
	Card[] DeckOfCards { get; set; }
	Card[] GetCardDeck();
}