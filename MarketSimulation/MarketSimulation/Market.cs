﻿using System;
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
	 * - marketListings: A list of all market buy and sell orders (listings).
	 */ 
	{	
		public List<Listing> marketListings  = new List<Listing>();
		public string Name { get; set; }

        public Market(string name)
		{
            Name = name;
		}
		
		public void addListing(Listing listing)
		{
			marketListings.Add(listing);
        }

		public List<Listing> sortBySellingItem(Item item)
		{
			List<Listing> itemList = new List<Listing>();

			foreach(Listing listing in marketListings)
			{
				if (listing.itemToSell == item)
				{
					itemList.Add
				}
			}

			return itemList;
		}

	}
}
