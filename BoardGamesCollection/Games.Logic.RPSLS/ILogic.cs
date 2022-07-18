namespace Games.RPSLS
{
	public interface ILogic
	{
		string Result { get; set; }

		string SelectedItemsValidator(string itemOne, string itemTwo);
	}
}