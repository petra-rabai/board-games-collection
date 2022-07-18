namespace Games.BlackJack.Models;

public interface ICardDeck
{
	List<Suit> DeckOfCards { get; set; }
	void GetCardDeck();
}