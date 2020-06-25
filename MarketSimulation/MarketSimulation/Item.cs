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
		public string Name { get; set; }
		public int Value { get; set; }
		public int Id { get; set; }
		public static int IncrementingId { get; set; }

		public Item(string itemName, int itemValue)
		{
			Name = itemName;
			Value = itemValue;
			Id = IncrementingId;
			//IncrementingId++;
		}
	} 
}