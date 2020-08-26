using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C968
{
	public class Outsourced : Part
	{
		public string CompanyName { get; set; }

		public Outsourced() { }
		public Outsourced(int partID, string name, double price, int instock, int max, int min, string companyname) : base(partID, name, price, instock, max, min)
		{
			CompanyName = companyname;
		}
		public Outsourced(string name, double price, int instock, int max, int min, string companyname) : base(name, price, instock, max, min)
		{
			CompanyName = companyname;
		}
	}
}
