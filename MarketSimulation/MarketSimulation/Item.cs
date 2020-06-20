using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Item
	/*
	 * Used to make items.
	 * 
	 * Variables:
	 * - name: name of the item
	 * - value: the hidden value of the item
	 */
	{
		public string name;
		// Description not necessary for test.
		public int value;

		public Item(string itemName, int itemValue)
		{
			name = itemName;
			value = itemValue;
		}
	}
}
