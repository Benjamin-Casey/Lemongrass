using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
	 * - marketListings;
	 * 
	 * NOTE: There may only be need for one set of listings rather than buyListing
	 *		 and sellListings since a listing implies that someone is always buying
	 *		 AND selling something. The functionality of buyListing and sellListing
	 *		 will be replaced with a sorting algorithm, e.g if you want to find a 
	 *		 listing selling an item it will sort for that listing.
	 */ 
	{	
		//public List<Listing> marketListings { get; set; }

        public List<Listing> marketListings = new List<Listing>();
		//public static List<Listing> marketListings;
		//public string[] marketListings = new string[1];
		public string Name { get; set; }

        public Market(string name)
		{
            Name = name;
			
			// Need an option to give marketListings, or if one isn't given, have a 
			// default constructor
		}
		
		
		public void addListing(Listing listing)
		{
			//market.marketListings[0] = listing;
			marketListings.Add(listing);
            //marketListings[x] = new listing;
			
        }

		public static void sortByItem()
		{
			
		}
	}
}
