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
	class Inventory
	{
		private static BindingList<Product> products = new BindingList<Product>();
		public static BindingList<Product> Products { get => products; set { products = value; } }


		private static BindingList<Part> part = new BindingList<Part>();
		public static BindingList<Part> AllParts { get => part; set { part = value; } }


		public static Part CurrentPart { get; set; }
		public static int CurrentPartIndex { get; set; }

		public static Product CurrentProduct { get; set; }
		public static int CurrentProductIndex { get; set; }

		public static Part CurrentAssociatedPart { get; set; }
		public static int CurrentAssociatedPartIndex { get; set; }

		








		// PART TIME

		public static void AddPart(Part part)
		{
			AllParts.Add(part);
		}

		public static bool DeletePart(Part part)
		{
			AllParts.Remove(part);
			return true;
		}

		public static Part SearchPart(int atIndex)
		{
			for (int i = 0; i < AllParts.Count; i++)
			{
				if (AllParts[i].PartID.Equals(atIndex))
				{
					return AllParts[i];
				}
				
			}
			return null;
		}

		public static void UpdatePart(int atIndex, Part part)
		{
			AllParts[atIndex] = part;
		}



















		// PRODUCTS


		public static void AddProduct(Product product)
		{
			Products.Add(product);
		}
		
		public static bool DeleteProduct(Product product)
		{
			Products.Remove(product);
			return true;
		}

		public static Product SearchProduct(int atIndex)
		{
			for (int i = 0; i < products.Count; i++)
			{
				if(Products[i].ProductID.Equals(atIndex))
				{
					return Products[i];
				}
			}
			return null;
		}

		public static void UpdateProduct(int atIndex, Product product)
		{
			Products[atIndex] = product;
		}













	}

}







