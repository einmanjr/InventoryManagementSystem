using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

namespace C968
{
	public class Product
	{

		public BindingList<Part> associatedParts = new BindingList<Part>();
		public BindingList<Part> AssociatedParts { get { return associatedParts; } set { associatedParts = value; } }


		public static int count;
		//private string v1;
		//private double v2;
		//private int v3;
		//private int v4;
		//private int v5;

		public int ProductID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int InStock { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }


	

		public Product() { }
		public Product(int productid, string name, double price, int instock, int max, int min)
		{
			ProductID = productid;
			Name = name;
			InStock = instock;
			Price = price;
			Max = max;
			Min = min;
		}

		public Product(string name, double price, int instock, int max, int min)
		{
			ProductID = count++;
			Name = name;
			InStock = instock;
			Price = price;
			Max = max;
			Min = min;
		}

		//public Product(string v1, double v2, int v3, int v4, int v5)
		//{
		//	this.v1 = v1;
		//	this.v2 = v2;
		//	this.v3 = v3;
		//	this.v4 = v4;
		//	this.v5 = v5;
		//}

		public void AddAssociatedPart(Part part)
		{
			this.AssociatedParts.Add(part);
		}
		
		public bool RemoveAssociatedPart(Part puts)
		{
			this.AssociatedParts.Remove(puts);
			return true;
		}

		public Part SearchForAssociatedPart(int asspartindex)
		{
			for(int i = 0; i < AssociatedParts.Count; i++)
			{
				if(AssociatedParts[i].PartID.Equals(asspartindex))
				{
					return AssociatedParts[i];
				}
			}
			return null;
		}
		


	}
}
