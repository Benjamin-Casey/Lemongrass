﻿using System;
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
	 * - ItemToSell:	The item obj that the player wants to sell for the buy item.
	 * - ItemToBuy:		The item obj that the player wants to buy for the sell item.
	 * - NumberToSell:	The number of the sell items that the player wants to exchange
	 *					for the number of the buy items.
	 * - NumberToBuy:	The number of buy items that the player wants to exchange for
	 *					the number of the sell items.
	 */
	{
		// There may be some error here with the incrementing ID. It's value may need to be loaded from a db otherwise it will reset to 0.
		private static int incrementingID = 0;
		public int Id;
		public Item ItemToSell { get; set; }
		public Item ItemToBuy { get; set; }
		public int NumberToSell { get; set; }
		public int NumberToBuy { get; set; }

		public Listing(Item sellItem, int numberOfSellItem, Item buyItem, int numberOfBuyItem)
		{
			ItemToSell = sellItem;
			ItemToBuy = buyItem;
			NumberToSell = numberOfSellItem;
			NumberToBuy = numberOfBuyItem;
			Id = incrementingID;
			incrementingID++;
		}
	}
}
