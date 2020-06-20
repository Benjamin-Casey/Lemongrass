using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Market
	/*
	 * Markets are a list of items that are for sale. The market will detail
	 * which items are for sale and their price.
	 *	
	 * Variables:
	 * - lowestPriceBuyList: Dictionary that contains the highest price buy
	 * request for each item <Item name: Price>
	 * - highestPriceSellList: Dictionary that contains the lowest price sell
	 * request for each item <Item name: Price>
	 * - buyListings: Dictionary that has key: name of the item, value: array
	 * of all buy listings for that item name.
	 * - sellListings: Dictionary that has key: name of item, value: array
	 * of all sale listings for that time.
	 * 
	 * NOTE: I've just realised that in a system where items are not traded for a
	 *		 currency things like 'lowest price' isn't relevant. fucking kms.
	 */
	{
		public Dictionary<string, int> lowestPriceBuyList;
		public Dictionary<string, int> highestPriceSellList;
		public Dictionary<string, int[]> buyListings;
		public Dictionary<string, int[]> sellListings;

		public Market()
		{

		}

		void update_lowestPriceBuyList()
		{
			// Goes through each item in buyListings and get the lowest price for
			// each item.
		}

		void update_highestPriceSellList()
		{
			// Goes through each item in sellListings and get the highest price
			// for each item.
		}
	}
}
