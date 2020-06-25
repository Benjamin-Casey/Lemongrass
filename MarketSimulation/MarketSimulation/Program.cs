using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MarketSimulation
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p1 = new Player();
			Item Lemon = new Item("Lemon", 1);
			Item Apple = new Item("Apple", 1);
			p1.AddToInventory(Lemon, 1);
			p1.AddToInventory(Apple, 2);
			Listing playerBuyListing = p1.CreateListing(Apple, 2, Lemon, 2);

			Market someTown = new Market("The Town of Some");
			someTown.AddListing(playerBuyListing);

			using (var db = new Database())
			{
				// Create and save new listing
				// Note: This adds one fixed listing. To make this more realistic
				//		 it should ask for user input to create different listings
				//		 each time.
				//var listing = new Listing(Lemon, 1, Apple, 1);
				db.ItemDb.Add(Lemon);
				db.SaveChanges();

				foreach (Item item in db.ItemDb)
				{
					Console.WriteLine(item.Name);
				}

				Console.ReadKey();
			}

		}
	}
}