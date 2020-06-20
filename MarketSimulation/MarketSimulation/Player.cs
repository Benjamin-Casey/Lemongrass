using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Player
	{
		public Dictionary<Item, int> inventory = new Dictionary<Item, int>();
		

		public void AddToInventory(Item item, int amt)
		{
			// Check if item is already in inventory. If it is, add amt.
			if(inventory.ContainsKey(item))
			{
				inventory[item] += amt;
			}
			else
			{
				inventory.Add(item, amt);
			}
		}

		
		public void RemoveFromInventory(Item item, int amt)
		// Remove from inventory
		{
			// Reduce the amt of the item in the inventory.
			inventory[item] -= amt;

			// If there is 0 or less, remove it from inventory.
			if(inventory[item] <= 0)
			{
				inventory.Remove(item);
			}
		}


		public Listing CreateListing(Item sellItem, int numSellItem, Item buyItem, int numBuyItem)
		{
			Listing buyListing = new Listing(sellItem, numSellItem, buyItem, numBuyItem);
			return buyListing;
		}
	}
}
