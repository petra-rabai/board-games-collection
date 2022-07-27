namespace Games.BlackJack.Models
{
	public class Dealer : IPlayer
	{
		private const string Name = "Dealer";
		public int Score { get; set; }
		public Decisions Decision { get; set; }

	}
}
