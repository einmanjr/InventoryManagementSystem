using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace C968
{
	public partial class MainForm : Form
	{



		public MainForm()
		{
			InitializeComponent();
			SetFormatting(dataGridView1);
			SetFormatting2(dataGridView2);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Inventory.AllParts;
			dataGridView1.ClearSelection();

			dataGridView2.DataSource = Inventory.Products;
			dataGridView2.ClearSelection();
		}

		public void BackToMainScreen()
		{
			MainForm BackToMain = new MainForm();
			this.Hide();
			BackToMain.Show();
		}













		private void SetFormatting(DataGridView dataGridView1)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
			dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			dataGridView1.RowHeadersVisible = false;
		}

		private void SetFormatting2(DataGridView dataGridView2)
		{
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
			dataGridView2.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			dataGridView2.RowHeadersVisible = false;
		}

		private void button_Parts_Add_Click(object sender, EventArgs e)
		{
			AddPart ap = new AddPart();
			this.Hide();
			ap.Show();
		}

		private void button_Parts_Modify_Click(object sender, EventArgs e)
		{
			try
			{
				ModifyPart mp = new ModifyPart();
				this.Hide();
				mp.Show();
			}
			catch
			{
				MessageBox.Show("Choose a PART to MODIFY!", "Main Form");
			}
		}

		private void button_Products_Add_Click(object sender, EventArgs e)
		{
			
			AddProduct ap = new AddProduct();
			this.Hide();
			ap.Show();
		}

		private void button_Products_Modify_Click(object sender, EventArgs e)
		{
			ModifyProduct mp = new ModifyProduct();
			this.Hide();
			mp.Show();
		}

		private void button_Parts_Delete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.RemoveAt(row.Index);
			}
		}

		private void button_Products_Delete_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView2.SelectedRows)
			{
				dataGridView2.Rows.RemoveAt(row.Index);
			}
		}


		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int a = e.RowIndex;
				int x = (int)dataGridView1.Rows[a].Cells[0].Value;
				Inventory.CurrentPart = Inventory.SearchPart(x);
				Inventory.CurrentPartIndex = a;
			}
			catch (Exception)
			{
				MessageBox.Show("Select a Part!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int b = e.RowIndex;
				int y = (int)dataGridView1.Rows[b].Cells[0].Value;
				Inventory.CurrentProduct = Inventory.SearchProduct(y);
				Inventory.CurrentProductIndex = b;
			}
			catch (Exception)
			{
				MessageBox.Show("Select a Product!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		// SEARCH TIME!


		private void button_Parts_Search_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Parts_Search.Text != "")
				{
					string theSearched = textBox_Parts_Search.Text.ToUpper();
					int rowIndex = -1;
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						if (row.Cells[1].Value.ToString().ToUpper().Contains(theSearched))
						{
							rowIndex = row.Index;
							row.Selected = true;
						}
					}
				}
				else
				{
					MessageBox.Show("Type into the search box what part you are looking for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot find that part! TRY AGAIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			textBox_Parts_Search.Clear();
		}

		private void button_Products_Search_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox_Products_Search.Text != "")
				{
					string theSearched = textBox_Products_Search.Text.ToUpper();
					int rowIndex = -1;
					foreach (DataGridViewRow row in dataGridView2.Rows)
					{
						if (row.Cells[1].Value.ToString().ToUpper().Contains(theSearched))
						{
							rowIndex = row.Index;
							break;
						}
					}
					dataGridView2.Rows[rowIndex].Selected = true;
				}
				else
				{
					MessageBox.Show("Type into the search box what Product you are looking for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Cannot find that Product! TRY AGAIN!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			textBox_Products_Search.Clear();
		}










		private void button_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}	
}
