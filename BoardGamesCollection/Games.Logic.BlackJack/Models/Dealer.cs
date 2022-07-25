namespace Games.BlackJack.Models
{
	public class Dealer : IPlayer
	{
		public int Score { get; set; }
		public Decisions Decision { get; set; }
	}
}
