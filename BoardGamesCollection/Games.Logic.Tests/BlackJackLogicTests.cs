using Games.BlackJack;
using FluentAssertions;
using Games.BlackJack.Models;

namespace Games.Tests;

public class BlackJackLogicTests
{

	[Test]
	public void CardPackCreationSuccess()
	{
		ICard card = new Card();
		ISuit suit = new Suit();

		CardDeck cardDeck = new CardDeck(card,suit);
		cardDeck.GetCardDeck();

		cardDeck.DeckOfCards.Should().NotBeEmpty();
		cardDeck.DeckOfCards.Count.Should().Be(52);
	}



}