using Games.Logic.RPSLS;

namespace Games.Logic.Tests
{
	public class Tests
	{
		[Test]
		public void IsComparableItemsValidatorSuccess()
		{
			BaseLogic baseLogic = new BaseLogic();
			baseLogic.CompareableItemsValidator();
		}
		
	}
}