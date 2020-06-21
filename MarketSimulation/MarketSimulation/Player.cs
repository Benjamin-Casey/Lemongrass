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

		public static void CreatePlayer()
		{
			
			Console.WriteLine("Enter Name:");
			string userInput = Console.ReadLine();

			Player newPlayer = new Player(playerList.Count + 1, userInput);
			playerList.Add(newPlayer);
			Console.WriteLine("Welcome {0}", newPlayer.PlayerName);

			/*
			if(playerList.Count > 0)
			{
				Player lastPlayer = playerList[playerList.Count - 1];
			}
			else 
			{
				add new player with id 0
			}
			*/

			Console.ReadKey();



		}
	}
}
