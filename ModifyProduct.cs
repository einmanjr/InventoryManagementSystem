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
	public partial class ModifyProduct : Form
	{
		public ModifyProduct()
		{
			InitializeComponent();

			textBox_ID.Enabled = false;

			textBox_ID.Text = Inventory.CurrentProduct.ProductID.ToString();
			textBox_Name.Text = Inventory.CurrentProduct.Name;
			textBox_Inventory.Text = Inventory.CurrentProduct.InStock.ToString();
			textBox_Price.Text = Inventory.CurrentProduct.Price.ToString();
			textBox_Max.Text = Inventory.CurrentProduct.Max.ToString();
			textBox_Min.Text = Inventory.CurrentProduct.Min.ToString();
		}


		public void BackToMainForm()
		{
			MainForm backtomain = new MainForm();
			this.Hide();
			backtomain.Show();
		}


		private void button_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Data will be lost", "Modify Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				BackToMainForm();
			}
		}

		private void ModifyProduct_Load(object sender, EventArgs e)
		{
			dataGridView_AllParts.DataSource = Inventory.AllParts;
			dataGridView_AllParts.ClearSelection();

			dataGridView_AssociatedParts.DataSource = Inventory.CurrentProduct.AssociatedParts;
			dataGridView_AssociatedParts.ClearSelection();
		}

		private void Search_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Search.Text != "")
				{
					String searchValue = textBox_Search.Text.ToUpper();
					int rowIndex = -1;
					foreach (DataGridViewRow row in dataGridView_AllParts.Rows)
					{
						if (row.Cells[1].Value.ToString().ToUpper().Contains(searchValue))
						{
							rowIndex = row.Index;
							break;
						}
					}
					dataGridView_AllParts.Rows[rowIndex].Selected = true;
				}
				else
				{
					MessageBox.Show("Cannot click Search button without any value in the Search text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot find part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			textBox_Search.Clear();
		}

		private void dataGridView_AllParts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int butt = e.RowIndex; 
				int ass = (int)dataGridView_AllParts.Rows[butt].Cells[0].Value; 
				Inventory.CurrentPart = Inventory.SearchPart(ass);
				Inventory.CurrentPartIndex = ass;
			}
			catch (Exception)
			{
				MessageBox.Show("Select a part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			if (Inventory.CurrentPart != null)
			{
				Inventory.CurrentProduct.AddAssociatedPart(Inventory.CurrentPart);

				ModifyProduct newmodprodform = new ModifyProduct();
				this.Hide();
				newmodprodform.Show();
			}
			else
			{
				MessageBox.Show("Choose something to modify", "Main Screen", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView_AssociatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int butt = e.RowIndex; 
				int ass = (int)dataGridView_AssociatedParts.Rows[butt].Cells[0].Value; 
				Inventory.CurrentAssociatedPart = Inventory.CurrentProduct.SearchForAssociatedPart(ass);

			}
			catch (Exception)
			{
				MessageBox.Show("Select a part.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button_Delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure? Data will be gone FOREVER", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Inventory.CurrentProduct.RemoveAssociatedPart(Inventory.CurrentAssociatedPart);

				ModifyProduct newmodprodform = new ModifyProduct();
				this.Hide();
				newmodprodform.Show();
			}
		}

		private void button_Save_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Name.Text == "" || textBox_Price.Text == "" || textBox_Inventory.Text == "" || textBox_Max.Text == "" || textBox_Min.Text == "")
				{
					MessageBox.Show("Enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					Inventory.CurrentProduct.ProductID = Convert.ToInt32(textBox_ID.Text);
					Inventory.CurrentProduct.Name = textBox_Name.Text;
					Inventory.CurrentProduct.Price = Convert.ToDouble(textBox_Price.Text);
					Inventory.CurrentProduct.InStock = Convert.ToInt32(textBox_Inventory.Text);
					Inventory.CurrentProduct.Max = Convert.ToInt32(textBox_Max.Text);
					Inventory.CurrentProduct.Min = Convert.ToInt32(textBox_Min.Text);

					Inventory.UpdateProduct(Inventory.CurrentProductIndex, Inventory.CurrentProduct); 

					BackToMainForm();
				}
			}
			catch (Exception exn)
			{
				MessageBox.Show(exn.Message);
			}
		}





		// VALIDATION ZONEEEEEEEE

		private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Letters ONLY for Name box!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
				MessageBox.Show("Enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				e.Handled = true;
			}
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

		

		// END OF VALIDATION ZONE






	}
}
