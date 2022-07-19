using FluentAssertions;
using Games.RPSLS;

namespace Games.Tests
{
	public class RPSLSLogicTests
	{
		[TestCase("Paper", "Scissor", ExpectedResult = "Scissor")]
		[TestCase("Scissor", "Paper", ExpectedResult = "Scissor")]
		[TestCase("Rock", "Scissor", ExpectedResult = "Rock")]
		[TestCase("Scissor", "Rock", ExpectedResult = "Rock")]
		[TestCase("Rock", "Lizard", ExpectedResult = "Rock")]
		[TestCase("Lizard", "Rock", ExpectedResult = "Rock")]
		[TestCase("Spock", "Lizard", ExpectedResult = "Lizard")]
		[TestCase("Lizard", "Spock", ExpectedResult = "Lizard")]
		[TestCase("Spock", "Scissor", ExpectedResult = "Spock")]
		[TestCase("Scissor", "Spock", ExpectedResult = "Spock")]
		[TestCase("Scissor", "Lizard", ExpectedResult = "Scissor")]
		[TestCase("Lizard", "Scissor", ExpectedResult = "Scissor")]
		[TestCase("Paper", "Lizard", ExpectedResult = "Lizard")]
		[TestCase("Lizard", "Paper", ExpectedResult = "Lizard")]
		[TestCase("Spock", "Paper", ExpectedResult = "Paper")]
		[TestCase("Paper", "Spock", ExpectedResult = "Paper")]
		[TestCase("Spock", "Rock", ExpectedResult = "Spock")]
		[TestCase("Rock", "Spock", ExpectedResult = "Spock")]
		[TestCase("Paper", "Rock", ExpectedResult = "Paper")]
		[TestCase("Rock", "Paper", ExpectedResult = "Paper")]
		[TestCase("", "", ExpectedResult = "Error! Items selection not success")]
		[TestCase("Cat", "Mouse", ExpectedResult = "Error! Selected items are invalid")]
		[Test]
		public string IsSelectedItemsValidatorSuccess(string testItemOne, string testItemTwo)
		{
			Logic gameLogic = new();

			gameLogic.SelectedItemsValidator(testItemOne, testItemTwo);

			gameLogic.Result.Should().NotBeEmpty();

			return gameLogic.Result;
		}
	}
}