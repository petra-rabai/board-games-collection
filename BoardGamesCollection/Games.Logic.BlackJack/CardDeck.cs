using Games.BlackJack.Models;

namespace Games.BlackJack;

public class CardDeck : ICardDeck
{

	public Card[] DeckOfCards { get; set; } = new Card[52];

	public Card[] GetCardDeck()
	{
		DeckOfCards = CreateDeck();

		return DeckOfCards;
	}

	private Card[] CreateDeck()
	{
		Card[] cards = new Card[DeckOfCards.Length];

		int cardIndex = 0;

		for (int suitCountIndex = 0; suitCountIndex < 4; suitCountIndex++)
		{
			int cardValue = 0;

			for (int cardItemIndex = 0; cardItemIndex < 13; cardItemIndex++)
			{
				Card card = new Card();

				if (suitCountIndex == 0)
				{
					card.Suit = "Diamonds";
				}
				else if (suitCountIndex == 1)
				{
					card.Suit = "Clubs";
				}
				else if (suitCountIndex == 2)
				{
					card.Suit = "Hearts";
				}
				else if (suitCountIndex == 3)
				{
					card.Suit = "Spades";
				}
				else
				{
					card.Suit = "";
				}

				cardValue++;

				card.Value = cardValue;

				if (card.Value == 1)
				{
					card.Name = card.Suit + "-" + "Ace";
				}
				else if (card.Value == 11)
				{
					card.Name = card.Suit + "-" + "King";
					card.Value = 10;
				}
				else if (card.Value == 12)
				{
					card.Name = card.Suit + "-" + "Queen";
					card.Value = 10;
				}
				else if (card.Value == 13)
				{
					card.Name = card.Suit + "-" + "Jack";
					card.Value = 10;
				}
				else
				{
					card.Name = card.Suit + "-" + card.Value.ToString();
				}

				card.Id = cardIndex;

				cards[cardIndex] = card;

				cardIndex++;
			}


		}

		return cards;
	}




}