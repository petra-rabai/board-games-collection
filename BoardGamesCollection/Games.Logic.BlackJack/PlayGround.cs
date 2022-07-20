using Games.BlackJack.Models;

namespace Games.BlackJack;

public class PlayGround
{
	private readonly ICardDeck _cardDeck;

	public PlayGround(ICardDeck cardDeck)
	{
		_cardDeck = cardDeck;
	}

	private Card[] _startDeck;
	private Card[] _playDeck;

	private Card[] _playerStartCards = new Card[2];

	public void Setup()
	{
		_startDeck = _cardDeck.GetCardDeck();
		_playDeck = InitializePlayDeck();
	}

	private Card[] InitializePlayDeck()
	{

		return _playDeck;
	}







}