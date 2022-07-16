using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logic.RPSLS
{
	public class Rule
	{

		public void Check(Item firstItem, Item secondItem)
		{
			Initialize(firstItem, secondItem);
		}

		private void Initialize(Item firstItem, Item secondItem)
		{
			if (firstItem.Name == "Paper" && secondItem.Name == "Scissor")
			{
				firstItem.Value = 0;
				secondItem.Value = 1;
			}
		}

	}
}
