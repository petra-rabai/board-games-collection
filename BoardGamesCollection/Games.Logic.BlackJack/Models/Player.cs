using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BlackJack.Models
{
	public class Player : IPlayer
	{
		public int Score { get; set; }
		public Decesions Decesion { get; set; }
		public string Name { get; set; }
		public int Credit { get; set; }
		public int Bet { get; set; }
	}
}
