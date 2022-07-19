namespace Games.BlackJack.Models;

public class CardDeck : ICardDeck
{
	private readonly ICard _card;
	private readonly ISuit _suit;

	public CardDeck(ICard card, ISuit suit)
	{
		_card = card;
		_suit = suit;
	}

	public List<Suit> DeckOfCards { get; set; }

	public void GetCardDeck()
	{
		DeckOfCards = CreateCardDeck();
	}


	private List<Suit> CreateCardDeck()
	{
		LoadCardSuitName();
		_card.Id = 0;
		for (int suitCountIndex = 0; suitCountIndex < _suit.Name.Length; suitCountIndex++)
		{
			for (int cardValue = 0; cardValue < 13; cardValue++)
			{
				_card.Value++;

				if (_card.Value == 1)
				{
					_card.Name = "Ace";
				}
				else if (_card.Value == 11)
				{
					_card.Name = "King";
					_card.Value = 10;
				}
				else if (_card.Value == 12)
				{
					_card.Name = "Queen";
					_card.Value = 10;
				}
				else if (_card.Value == 13)
				{
					_card.Name = "Jack";
					_card.Value = 10;
				}
				else
				{
					_card.Name = _card.Value.ToString();
				}
				Suit suit = new Suit();
				suit.Name[suitCountIndex] = _suit.Name[suitCountIndex];
				suit.CardItem.Id = _card.Id;
				suit.CardItem.Name = _card.Name;
				suit.CardItem.Value = _card.Value;
				suit.CardItem.Suit = _suit.Name[suitCountIndex];

				DeckOfCards.Add(suit);
				_card.Id++;
			}

			_card.Value = 0;
		}

		return DeckOfCards;
	}

	private string[] LoadCardSuitName()
	{
		_suit.Name = new string[4];

		_suit.Name[0] = "Diamonds";
		_suit.Name[1] = "Clubs";
		_suit.Name[2] = "Hearts";
		_suit.Name[3] = "Spades";

		return _suit.Name;
	}


}