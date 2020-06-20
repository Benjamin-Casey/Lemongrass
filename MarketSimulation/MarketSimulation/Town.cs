using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{
	class Town
	/*
	 * This class is used to build towns.
	 * 
	 * Variables:
	 *	- name: the name of the town
	 *	- nearbyTowns - Town array: list of nearby towns (Maybe only towns within
	 *	a certain distance. 
	 */
	{
		public string name;
		public Town[] nearbyTowns;
		public Market market;

		public Town(string townName)
		{
			name = townName;
			// nearbyTowns = nearbyTownsArray. Need a default constructor.
		}
	}
}
