using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Logic.RPSLS
{
	public class ItemsValidator
	{
		public Item Winner { get; set; }
		
		private List<Item> _choosedItems = new List<Item>();
		private Item _choosedItem = new Item();

		public List<Item> GetItemsForValidation(Item firstItem, Item secondItem)
		{
			_choosedItems.Add(firstItem);
			_choosedItems.Add(secondItem);

			return _choosedItems;
		}

		public Item GetWinnerItem()
		{
			Winner = CheckItems();

			return Winner;
		}

		private Item CheckItems()
		{
			int currentValue = _choosedItems[0].Value;
			
			for (int i = 0; i < _choosedItems.Count; i++)
			{
				_choosedItem = _choosedItems[i];

				if (_choosedItem.Value > currentValue)
				{
					currentValue = _choosedItem.Value;
					_choosedItem = _choosedItems[i];
				}
			}

			return _choosedItem;
		}


	}
}
