using Games.BlackJack.Models;

namespace Games.BlackJack;

public class CardDecks : ICardDecks
{
	private readonly ICardPack _cardPack;

	public CardDecks(ICardPack cardPack)
	{
		_cardPack = cardPack;
	}

	private Card[] _startDeck;

	public Card[] BoardDeck { get; set; }
	public Card[] PlayerDeck { get; set; }
	public Card[] DealerDeck { get; set; }

	public void Setup()
	{
		_startDeck = _cardPack.GetCardPack();
		PlayerDeck = InitializeDeck(_startDeck, PlayerDeck, 2);
		DealerDeck = InitializeDeck(BoardDeck, DealerDeck, 2);
	}

	private Card[] InitializeDeck(Card[] originalDeck, Card[] playerDeck, int startCardCount)
	{
		Random cardChooser = new Random();
		playerDeck = new Card[startCardCount];

		for (int i = 0; i < startCardCount; i++)
		{
			int chooserHelper = cardChooser.Next(originalDeck.Length);
			playerDeck[i] = originalDeck[chooserHelper];
			originalDeck = originalDeck.Where(cards => cards != playerDeck[i]).ToArray();
		}

		BoardDeck = originalDeck;

		return playerDeck;
	}







}