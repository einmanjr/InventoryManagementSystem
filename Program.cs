using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace C968
{
	static class Program
	{
	
		[STAThread]
		static void Main()
		{



			Inventory.AddPart(new InHouse("Wheel", 12.11, 15, 25, 5, 6465464));
			Inventory.AddPart(new InHouse("Pedal", 8.22, 11, 25, 5, 54431431));
			Inventory.AddPart(new Outsourced("Chain", 8.33, 12, 25, 5, "Chain Co."));
			Inventory.AddPart(new Outsourced("Seat", 4.55, 8, 15, 2, "Seats r' us"));



			Inventory.Products.Add(new Product("Red Bicycle", 11.44, 15, 25, 1));
			Inventory.Products.Add(new Product("Yellow Bicycle", 9.66, 19, 20, 1));
			Inventory.Products.Add(new Product("Blue Bicycle", 12.77, 5, 25, 1));
			










			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
