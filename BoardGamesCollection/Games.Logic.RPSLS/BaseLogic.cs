using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logic.RPSLS
{
	public class BaseLogic : IBaseLogic
	{
		public string Winner { get; set; }

		private List<string> choosedGameItems = new List<string>();

		private Dictionary<Tuple<string, string>, string> winnerCheck = new Dictionary<Tuple<string, string>, string>()
		{
				{new Tuple<string, string>("Paper", "Scissor"), "Scissor"},
				{new Tuple<string, string>("Scissor", "Paper"), "Scissor"},
				{new Tuple<string, string>("Rock", "Scissor"), "Rock"},
				{new Tuple<string, string>("Scissor", "Rock"), "Rock"},
				{new Tuple<string, string>("Rock", "Lizard"), "Rock"},
				{new Tuple<string, string>("Lizard", "Rock"), "Rock"},
				{new Tuple<string, string>("Lizard", "Spock"), "Lizard"},
				{new Tuple<string, string>("Spock", "Lizard"), "Lizard"},
				{new Tuple<string, string>("Spock", "Scissor"), "Spock"},
				{new Tuple<string, string>("Scissor", "Spock"), "Spock"},
				{new Tuple<string, string>("Scissor", "Lizard"), "Scissor"},
				{new Tuple<string, string>("Lizard", "Scissor"), "Scissor"},
				{new Tuple<string, string>("Paper", "Lizard"), "Lizard"},
				{new Tuple<string, string>("Lizard", "Paper"), "Lizard"},
				{new Tuple<string, string>("Paper", "Spock"), "Paper"},
				{new Tuple<string, string>("Spock", "Paper"), "Paper"},
				{new Tuple<string, string>("Rock", "Spock"), "Spock"},
				{new Tuple<string, string>("Spock", "Rock"), "Spock"},
				{new Tuple<string, string>("Rock", "Paper"), "Paper"},
				{new Tuple<string, string>("Paper", "Rock"), "Paper"}
		};

		private Tuple<string, string> comperableItems;


		public string CompareableItemsValidator(string itemOne, string itemTwo)
		{
			choosedGameItems = GetChoosedGameItems(itemOne, itemTwo);

			comperableItems = LoadCompareableItems();

			if (winnerCheck.ContainsKey(comperableItems))
			{
				Winner = winnerCheck[comperableItems];
			}

			return Winner;
		}

		private List<string> GetChoosedGameItems(string itemOne, string itemTwo)
		{
			choosedGameItems.Add(itemOne);
			choosedGameItems.Add(itemTwo);

			return choosedGameItems;
		}

		private Tuple<string, string> LoadCompareableItems()
		{
			comperableItems = new Tuple<string, string>(choosedGameItems[0], choosedGameItems[1]);

			return comperableItems;
		}


	}
}
