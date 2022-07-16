using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logic.RPSLS
{
	public class Items
	{
		public enum Rock
		{
			Scissor,
			Spock,
			Paper
		}

		public enum Scissor
		{
			Paper,
			Lizard
		}

		public enum Lizard
		{
			Spock,
			Paper
		}

		public enum Spock
		{
			Rock,
			Scissor
		}

		public enum Paper
		{
			Rock,
			Spock
		}

	}
}
