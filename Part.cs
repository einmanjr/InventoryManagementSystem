using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;

namespace C968
{
	public abstract class  Part
	{
		

		public static int count;
		public int PartID { get; set; }
	    public string Name { get; set; }
		public double Price { get; set; }
		public int InStock { get; set; }
		public int Max { get; set; }
		public int Min { get; set; }

		protected Part(int partid, string name, double price, int instock, int max, int min)
		{
			PartID = partid;
			Name = name;
			Price = price;
			InStock = instock;
			Max = max;
			Min = min;
		}

		protected Part(string name, double price, int instock, int max, int min)
		{
			PartID = count++;
			Name = name;
			Price = price;
			InStock = instock;
			Max = max;
			Min = min;
		}

		protected Part() { }


	}
}
