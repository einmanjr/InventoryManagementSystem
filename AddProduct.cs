using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
	public partial class AddProduct : Form
	{

		Product futureProduct;

		public AddProduct()
		{
			InitializeComponent();

			textBox_ID.Enabled = false;

			futureProduct = new Product("fake", 88.00, 8, 3, 91);

			dataGridView_AllParts.DataSource = Inventory.AllParts;
			dataGridView_AssociatedParts.DataSource = futureProduct.AssociatedParts;
		}

















		public void BackToMainForm()
		{
			MainForm backtomain = new MainForm();
			this.Hide();
			backtomain.Show();
		}



		private void AddProduct_Load(object sender, EventArgs e)
		{
			dataGridView_AssociatedParts.ClearSelection();
			dataGridView_AssociatedParts.DataSource = futureProduct.AssociatedParts;
		}

		private void Search_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Search.Text != "")
				{
					String searchValue = textBox_Search.Text.ToUpper();
					int rowindex = -1;
					foreach (DataGridViewRow row in dataGridView_AllParts.Rows)
					{
						if (row.Cells[1].Value.ToString().ToUpper().Contains(searchValue))
						{
							rowindex = row.Index;
							break;
						}
					}
					dataGridView_AllParts.Rows[rowindex].Selected = true;
				}
				else
				{
					MessageBox.Show("Enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch
			{
				MessageBox.Show("No Part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			textBox_Search.Clear();
		}

		private void dataGridView_AllParts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int api = dataGridView_AllParts.CurrentCell.RowIndex;
				Inventory.CurrentPart = Inventory.SearchPart((int)dataGridView_AllParts.Rows[api].Cells[0].Value);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			if (Inventory.CurrentPart != null)
			{
				futureProduct.AddAssociatedPart(Inventory.CurrentPart);
				dataGridView_AssociatedParts.DataSource = futureProduct.AssociatedParts;
			}
			else
			{
				MessageBox.Show("Choose a part to modify");
			}
		}

		private void button_Delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				futureProduct.RemoveAssociatedPart(Inventory.CurrentAssociatedPart);
			}
		}

		private void dataGridView_AssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int apindex = dataGridView_AssociatedParts.CurrentCell.RowIndex;

				Inventory.CurrentAssociatedPart = futureProduct.SearchForAssociatedPart((int)dataGridView_AssociatedParts.Rows[apindex].Cells[0].Value);
			}
			catch (Exception)
			{
				MessageBox.Show("Select an Associated Part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure? This information will be discarded", "Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMainForm();
			}
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Name.Text == "" || textBox_Price.Text == "" || textBox_Inventory.Text == "" || textBox_Max.Text == "" || textBox_Min.Text == "")
				{
					MessageBox.Show("Must enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (Convert.ToInt32(textBox_Min.Text) > Convert.ToInt32(textBox_Max.Text))
				{
					MessageBox.Show("Minimum value should be less than Maximum value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (Convert.ToInt32(textBox_Inventory.Text) > Convert.ToInt32(textBox_Max.Text))
				{
					MessageBox.Show("Inventory value should be between Maximum and Minimum values", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					futureProduct.Name = textBox_Name.Text;
					futureProduct.Price = Convert.ToDouble(textBox_Price.Text);
					futureProduct.InStock = Convert.ToInt32(textBox_Inventory.Text);
					futureProduct.Max = Convert.ToInt32(textBox_Max.Text);
					futureProduct.Min = Convert.ToInt32(textBox_Min.Text);

					Inventory.AddProduct(futureProduct);

					BackToMainForm();
				}
			}
			catch (Exception pp)
			{
				MessageBox.Show(pp.Message);
			}
		}



		// VALIDATION ZONE -- for data entries
		private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
		{
			//OOPS didn't mean to click this one, it might make an ERROR for me later
		}

		private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Name should contain Letters only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void textBox_Inventory_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
			{
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("Enter numeric data only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				e.Handled = true;
			}
		}

		private void textBox_Price_TextChanged(object sender, EventArgs e)
		{
			//SHIT
		}

		private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '.' && textBox_Price.Text.Contains("."))
			{
				e.Handled = true;
				MessageBox.Show("Incorrect data entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if (e.KeyChar == '.' && textBox_Price.Text.Length == 0)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect data entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void textBox_Max_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
			{
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("Enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				e.Handled = true;
			}
		}

		private void textBox_Min_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
			{
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("Enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				e.Handled = true;
			}
		}

		//END OF VALIDATION ZONE









	}
}
