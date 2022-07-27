using Games.BlackJack.Models;

namespace Games.BlackJack
{
	public interface IPlayer
	{
		int Score { get; set; }
		Decisions Decision { get; set; }

	}
}
