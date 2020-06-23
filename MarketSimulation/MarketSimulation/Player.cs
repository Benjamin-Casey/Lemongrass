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

		public Dictionary<Item, int> inventory = new Dictionary<Item, int>();
		
		public Player(int Id, string name)
		{
			PlayerName = name;
			PlayerID = Id;
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
			Item matchedItem = null;

			for (int i = 0; i < Item.itemList.Count; i++)
			{
				if (Item.itemList[i].name == itemInput)
				{
					matchedItem = Item.itemList[i];
					break;
				}
			}

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
			Listing buyListing = new Listing(sellItem, numSellItem, buyItem, numBuyItem, playerObject);
			return buyListing;
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
			Console.WriteLine(playerList.BinarySearch(player));
			Console.ReadKey();
			return playerList.BinarySearch(player);
		}

		public void displayInventory()
		{
			foreach (KeyValuePair<Item, int> item in inventory)
			{
				Console.WriteLine("Name: {0}, Amount: {1}", item.Key.name, item.Value);
			}
		}
	}
}
