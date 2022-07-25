namespace Games.BlackJack.Models
{
	public class Player : IPlayer
	{
		public int Score { get; set; }
		public Decisions Decision { get; set; }
		public string Name { get; set; }
		public int Credit { get; set; }
		public int Bet { get; set; }
	}
}
