namespace Games.BlackJack.Models;

public class GameBoard
{
	private readonly IPlayer _player;
	private readonly ICardDecks _cardDecks;

	public GameBoard(IPlayer player, ICardDecks cardDecks)
	{
		_player = player;
		_cardDecks = cardDecks;
	}

	public int Round { get; set; }
	public int PlayerBet { get; set; }

	private Card[] _boardDeck;
	private Card[] _playerDeck;
	private Card[] _dealerDeck;
	private Decisions _playerDecision;
	private Decisions _dealerDecision;

	private void Init()
	{
		SetupDecks();
		PlayerBet = GetPlayerBet();
		Round = GetRound(PlayerBet);
		if (Round == 1)
		{
			Card plyerFirstCard = _playerDeck[0];
			Card dealerFirstCard = _dealerDeck[0];
			Card plyerSecondCard = _playerDeck[1];

			DisplayFirstCardsToThePlayer(plyerFirstCard, dealerFirstCard);
			DisplayeSecondCardsToThePlayer(plyerSecondCard);
			if ((plyerFirstCard.Name == "Ace" || plyerSecondCard.Name == "Ace") || (plyerFirstCard.Name == "King" || plyerFirstCard.Name == "Queen" || plyerFirstCard.Name == "Jack") || (plyerSecondCard.Name == "King" || plyerSecondCard.Name == "Queen" || plyerSecondCard.Name == "Jack"))
			{
				_player.Score = 1;
			}
			else
			{
				_playerDecision = _player.Decision;
				do
				{
					AddNewCardToThePlayer(_playerDeck, _playerDeck);
					CheckCardsValue(_playerDeck);
				} while (_playerDecision == Decisions.Hit);

			}
		}
	}

	private int GetRound(int playerBet)
	{
		throw new NotImplementedException();
	}

	private int GetPlayerBet()
	{
		throw new NotImplementedException();
	}

	private void SetupDecks()
	{
		_cardDecks.Setup();
		_boardDeck = _cardDecks.BoardDeck;
		_playerDeck = _cardDecks.PlayerDeck;
		_dealerDeck = _cardDecks.DealerDeck;

	}

}