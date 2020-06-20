using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Program
	{
		static void Main(string[] args)
		{
			Item Lemon = new Item("Lemon", 1);
			Item Cow = new Item("Cow", 4);

			Listing lemonBuyList = new Listing(Lemon, 4, Cow, 1);
			Listing cowBuyList = new Listing(Cow, 1, Lemon, 4);

			Market town1Market = new Market("Clunes");
			Market town2Market = new Market("Everton Park");

            Console.WriteLine(town2Market.Name);
			town2Market.Name = "Clowns";
            Console.WriteLine(town2Market.Name);
            Console.ReadKey();

			town1Market.addListing(lemonBuyList);
			town2Market.addListing(cowBuyList);
        }
	}
}
