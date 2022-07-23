using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BlackJack.Models
{
	public class Dealer : IPlayer
	{
		public int Score { get; set; }
		public Decesions Decesion { get; set; }
	}
}
