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
		public static List<Item> itemList = new List<Item>();
		public string name;
		public int value;
		// Description not necessary for test.

		public Item(string itemName, int itemValue)
		{
			name = itemName;
			value = itemValue;
		}


		public static void ItemCreation()
		{
			Item Lemon = new Item("Lemon", 1);
			Item Apple = new Item("Apple", 1);
			Item Banana = new Item("Banana", 1);
			Item Spinach = new Item("Spinach", 1);
			Item Cow = new Item("Cow", 1);
			itemList.Add(Lemon);
			itemList.Add(Apple);
			itemList.Add(Banana); itemList.Add(Spinach); itemList.Add(Cow);
		}
	} 

}