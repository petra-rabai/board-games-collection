using Games.BlackJack.Models;

namespace Games.BlackJack
{
	public interface ICardDecks
	{
		Card[] BoardDeck { get; set; }
		Card[] DealerDeck { get; set; }
		Card[] PlayerDeck { get; set; }

		void Setup();
	}
}