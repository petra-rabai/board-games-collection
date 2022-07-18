namespace Games.RPSLS
{
	public class Logic : ILogic
	{
		public string Result { get; set; } = "";

		private List<string> _selectedGameItems = new();

		private readonly Dictionary<Tuple<string, string>, string> _resultCheck = new Dictionary<Tuple<string, string>, string>()
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

		private Tuple<string, string> _selectedItems;


		public string SelectedItemsValidator(string itemOne, string itemTwo)
		{
			if (!string.IsNullOrEmpty(itemOne) && !string.IsNullOrEmpty(itemTwo))
			{
				_selectedGameItems = GetSelectedGameItems(itemOne, itemTwo);

				_selectedItems = LoadSelectedItems();

				Result = _resultCheck.ContainsKey(_selectedItems)
					? _resultCheck[_selectedItems]
					: "Error! Selected items are invalid";
			}
			else
				Result = "Error! Items selection not success";

			return Result;
		}

		private List<string> GetSelectedGameItems(string itemOne, string itemTwo)
		{
			_selectedGameItems.Add(itemOne);
			_selectedGameItems.Add(itemTwo);

			return _selectedGameItems;
		}

		private Tuple<string, string> LoadSelectedItems()
		{
			return new Tuple<string, string>(_selectedGameItems[0], _selectedGameItems[1]);
		}


	}
}
