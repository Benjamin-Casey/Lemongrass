using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Listing
	/*
	 * Market listing that contains x amt of items that want to be exchanged for x 
	 * other items.
	 * 
	 * Variables:
	 * - itemToSell:	The item obj that the player wants to sell for the buy item.
	 * - itemToBuy:		The item obj that the player wants to buy for the sell item.
	 * - numberToSell:	The number of the sell items that the player wants to exchange
	 *					for the number of the buy items.
	 * - numberToBuy:	The number of buy items that the player wants to exchange for
	 *					the number of the sell items.
	 */
	{
		public Item itemToSell { get; set; }
		public Item itemToBuy { get; set; }
		public int numberToSell { get; set; }
		public int numberToBuy { get; set; }

		public Listing(Item sellItem, int numberOfSellItem, Item buyItem, int numberOfBuyItem)
		{
			this.itemToSell = sellItem;
			itemToBuy = buyItem;
			numberToSell = numberOfSellItem;
			numberToBuy = numberOfBuyItem;
		}
	}
}
