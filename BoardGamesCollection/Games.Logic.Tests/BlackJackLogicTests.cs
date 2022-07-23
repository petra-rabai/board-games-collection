using FluentAssertions;
using Games.BlackJack;
using Games.BlackJack.Models;

namespace Games.Tests;

public class BlackJackLogicTests
{

	[Test]
	public void CardPackCreationSuccess()
	{
		CardPack cards = new CardPack();

		Card[] testCards = cards.GetCardPack();

		testCards.Should().BeEquivalentTo(cards.Cards);
		testCards.Should().NotBeEmpty();
		testCards.Length.Should().Be(cards.Cards.Length);
	}

	[Test]
	public void CardDecksSetupSuccess()
	{
		ICardPack cardDeck = new CardPack();
		CardDecks cardDecks = new CardDecks(cardDeck);

		cardDecks.Setup();

		cardDecks.DealerDeck.Should().NotBeEmpty();
		cardDecks.PlayerDeck.Should().NotBeEmpty();
		cardDecks.BoardDeck.Should().NotBeEmpty();

		cardDecks.BoardDeck.Should().NotBeEquivalentTo(cardDeck.Cards);
		cardDecks.PlayerDeck.Should().NotBeEquivalentTo(cardDecks.DealerDeck);

		cardDecks.DealerDeck.Length.Should().Be(2);
		cardDecks.PlayerDeck.Length.Should().Be(2);
		cardDecks.BoardDeck.Length.Should().Be(48);

	}


}