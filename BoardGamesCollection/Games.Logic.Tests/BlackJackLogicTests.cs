using FluentAssertions;
using Games.BlackJack;
using Games.BlackJack.Models;

namespace Games.Tests;

public class BlackJackLogicTests
{

	[Test]
	public void CardPackCreationSuccess()
	{
		CardDeck cardDeck = new CardDeck();

		Card[] testDeckOfCards = cardDeck.GetCardDeck();

		testDeckOfCards.Should().BeEquivalentTo(cardDeck.DeckOfCards);
		testDeckOfCards.Should().NotBeEmpty();
		testDeckOfCards.Length.Should().Be(cardDeck.DeckOfCards.Length);
	}


}