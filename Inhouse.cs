using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C968
{
	public class InHouse : Part
	{
		public int MachineID { get; set; }

		public InHouse() { }
		public InHouse(int partID, string name, double price, int instock, int max, int min, int machineid) : base(partID, name, price, instock, max, min)
		{
			MachineID = machineid;
		}

		public InHouse(string name, double price, int instock, int max, int min, int machineID) : base( name,price, instock, max, min)
		{
			MachineID = machineID;
		}

	}
}
