using Games.BlackJack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.BlackJack
{
	public interface IPlayer
	{
		int Score { get; set; }
		Decesions Decesion { get; set; }
	}
}
