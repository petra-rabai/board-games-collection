namespace Games.Logic.RPSLS
{
	public interface IBaseLogic
	{
		string Winner { get; set; }

		string CompareableItemsValidator(string itemOne, string itemTwo);
	}
}