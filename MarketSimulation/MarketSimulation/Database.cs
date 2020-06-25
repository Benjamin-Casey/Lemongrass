using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MarketSimulation
{
	class Database : DbContext
	{
		public DbSet<Item> ItemDb { get; set; }


		public void SetItemId()
		 // Sets "Item"'s incrementingId.
		{
			var highestIdItem = ItemDb.OrderByDescending(i => i.Id).FirstOrDefault();
			if (highestIdItem != null)
			{
				Item.IncrementingId = highestIdItem.Id + 1;
			} else
			{
				Item.IncrementingId = 0;
			}
		}
	}
}
