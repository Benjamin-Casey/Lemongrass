using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Player
	{
		public int PlayerID { get; set; }
		public string PlayerName { get; set; }

		// assigns the player a town object that will be based on their location (atm only 1 town)
		public Town PlayerTown;

		public Dictionary<Item, int> inventory = new Dictionary<Item, int>();

		//stores the players current 'listing' objects
		public List<Listing> playerListings = new List<Listing>();

		public Player(int Id, string name)
		{
			PlayerName = name;
			PlayerID = Id;
			Market lemonMarket = new Market("Lemon Market");
			Town lemonTown = new Town("Lemon Town", lemonMarket);
			PlayerTown = lemonTown;
		}

		public static List<Player> playerList = new List<Player>();



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
		public void AddToInventory()
		{
			// Check if item is already in inventory. If it is, add amt.
			Console.WriteLine("Enter Item Name:");
			string itemInput = Console.ReadLine();
			Console.WriteLine("Enter Item Amount:");
			string amountInput = Console.ReadLine();
			Item matchedItem = MatchItem(itemInput);

			if (inventory.ContainsKey(matchedItem))
			{
				inventory[matchedItem] += Int32.Parse(amountInput);
			}
			else
			{
				inventory.Add(matchedItem, Int32.Parse(amountInput));
			}
			Console.WriteLine("Added {0} {1}s ", amountInput, matchedItem.name);
			Console.ReadKey();
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


		public Listing CreateListing(Item sellItem, int numSellItem, Item buyItem, int numBuyItem, Player playerObject)
		{
			Listing newListing = new Listing(sellItem, numSellItem, buyItem, numBuyItem, playerObject);
			this.playerListings.Add(newListing);
			this.PlayerTown.market.AddListing(newListing);
			return newListing;
		}
		public Listing CreateListing()
		{
			Console.WriteLine("Enter Item to Sell:");
			string itemSellInput = Console.ReadLine();
			Console.WriteLine("Enter Amount to Sell:");
			string amountSellInput = Console.ReadLine();
			Console.WriteLine("Enter Item to Buy:");
			string itemBuyInput = Console.ReadLine();
			Console.WriteLine("Enter Amount to Buy:");
			string amountBuyInput = Console.ReadLine();
			Item sellItem = MatchItem(itemSellInput);
			Item buyItem = MatchItem(itemBuyInput);

			Listing newListing = new Listing(sellItem, Int32.Parse(amountSellInput), buyItem, Int32.Parse(amountBuyInput), this); //idk if 'this' is correct or the big dumb
			this.playerListings.Add(newListing); // adds the new listing to the player's listings list
			this.PlayerTown.market.AddListing(newListing);
			return newListing;
		}

		// takes a user imput string for an 'item' and returns it's item object
		public Item MatchItem(String name)
		{
			Item matchedItem = null;

			for (int i = 0; i < Item.itemList.Count; i++)
			{
				if (Item.itemList[i].name == name)
				{
					matchedItem = Item.itemList[i];
					return matchedItem;
				}
			}
			return matchedItem; // will be null in this case and will probs break stuff
		}

		public static Player CreatePlayer()
		{
			
			Console.WriteLine("Enter Name:");
			string userInput = Console.ReadLine();

			Player newPlayer = new Player(playerList.Count + 1, userInput);
			playerList.Add(newPlayer);
			Console.WriteLine("Welcome {0}", newPlayer.PlayerName);
			Console.ReadKey();
			return newPlayer;
		}
		public static int PlayerIndex(Player player)
		{
			return playerList.BinarySearch(player);
		}

		public void displayInventory()
		{
			foreach (KeyValuePair<Item, int> item in inventory)
			{
				Console.WriteLine("Name: {0}, Amount: {1}", item.Key.name, item.Value);
			}
		}

		public void DisplayAllListings(List<Listing> list)
		// Prints all listings from a list of 'Listing' objects
		{

			foreach (Listing Object in list)
			{
				Console.WriteLine("Selling " + Object.NumberToSell + " " + Object.ItemToSell.name + "s For " + Object.NumberToBuy + " " +Object.ItemToBuy.name + "s" );
			}
		}
	}
}
