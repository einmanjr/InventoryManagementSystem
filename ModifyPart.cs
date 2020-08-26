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
	public partial class ModifyPart : Form
	{




		private void FillOut(Outsourced outpart)
		{
			textBox_variable.Text = outpart.CompanyName;
		}

		private void FillIn(InHouse inpart)
		{
			textBox_variable.Text = inpart.MachineID.ToString();
		}





		private void FillO(Outsourced outpart)
		{
			outpart.CompanyName = textBox_variable.Text;
		}

		private void FillI(InHouse inpart)
		{
			inpart.MachineID = Convert.ToInt32(textBox_variable.Text);
		}











		public ModifyPart()
		{
			InitializeComponent();

			textBox_ID.Enabled = false;

			

			textBox_ID.Text = Inventory.CurrentPart.PartID.ToString();
			textBox_Name.Text = Inventory.CurrentPart.Name;
			textBox_Inventory.Text = Inventory.CurrentPart.InStock.ToString();
			textBox_Price.Text = Inventory.CurrentPart.Price.ToString();
			textBox_Max.Text = Inventory.CurrentPart.Max.ToString();
			textBox_Min.Text = Inventory.CurrentPart.Min.ToString();

			if (Inventory.CurrentPart.GetType() == typeof(Outsourced))
			{
				radioButton_Outsourced.Checked = true;
				IsInHouse = false; // MAYBE HERE
				FillOut((Outsourced)Inventory.CurrentPart);
			}
			else
			{
				radioButton_InHouse.Checked = true;
				IsInHouse = true; 
				FillIn((InHouse)Inventory.CurrentPart);
			}




		}

		public bool IsInHouse;

		public void BackToMainForm()
		{
			MainForm backtomain = new MainForm();
			this.Hide();
			backtomain.Show();
		}




		// H.2 SAVE CHANGES

		private void button_Save_Click(object sender, EventArgs e)
		{
			try
			{

				if (textBox_Name.Text == "" || textBox_Inventory.Text == "" || textBox_Price.Text == "" || textBox_Max.Text == "" || textBox_Min.Text == "")
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

					Inventory.CurrentPart.PartID = Convert.ToInt32(textBox_ID.Text);
					Inventory.CurrentPart.Name = textBox_Name.Text;
					Inventory.CurrentPart.InStock = Convert.ToInt32(textBox_Inventory.Text);
					Inventory.CurrentPart.Price = Convert.ToDouble(textBox_Price.Text);      
					Inventory.CurrentPart.Max = Convert.ToInt32(textBox_Max.Text);
					Inventory.CurrentPart.Min = Convert.ToInt32(textBox_Min.Text);

					if (Inventory.CurrentPart.GetType() == typeof(Outsourced))    
					{
						if (IsInHouse)      //MAYBE------ I THINK I FIXED IT
						{                             //THIS??? BELOW
							var temporarypart = new InHouse(Inventory.CurrentPart.PartID, Inventory.CurrentPart.Name, Inventory.CurrentPart.Price, Inventory.CurrentPart.InStock, Inventory.CurrentPart.Min, Inventory.CurrentPart.Max, 0); 
							FillI(temporarypart);
							Inventory.UpdatePart(Inventory.CurrentPartIndex, temporarypart);
						}
						else
						{
							FillO((Outsourced)Inventory.CurrentPart);
							Inventory.UpdatePart(Inventory.CurrentPartIndex, Inventory.CurrentPart);
						}
					}
					else
					{
						if (!IsInHouse)
						{
							var temporarypart = new Outsourced(Inventory.CurrentPart.PartID, Inventory.CurrentPart.Name, Inventory.CurrentPart.Price, Inventory.CurrentPart.InStock, Inventory.CurrentPart.Min, Inventory.CurrentPart.Max, "Some Company");
							FillO(temporarypart);
							Inventory.UpdatePart(Inventory.CurrentPartIndex, temporarypart);
						}
						else
						{
							FillI((InHouse)Inventory.CurrentPart);
							Inventory.UpdatePart(Inventory.CurrentPartIndex, Inventory.CurrentPart);
						}
					}
					BackToMainForm();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void radioButton_InHouse_CheckedChanged(object sender, EventArgs e)
		{
			variable.Text = "MachineID";
			IsInHouse = true;
			textBox_variable.Clear();

		}

		private void radioButton_Outsourced_CheckedChanged(object sender, EventArgs e)
		{
			variable.Text = "Company Name";
			IsInHouse = false;
			textBox_variable.Clear();
		}





		// VALIDATION ZONEEEEEEEE

		private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Letters only for Name Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void textBox_Inventory_KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
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
			if(e.KeyChar == '.' && textBox_Price.Text.Contains("."))
			{
				e.Handled = true;
				MessageBox.Show("Incorrect data entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if (e.KeyChar == '.' && textBox_Price.Text.Length == 0)
			{
				e.Handled = true;
				MessageBox.Show("Incorrect data entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
				base.OnKeyPress(e);
				MessageBox.Show("Enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}


		private void textBox_Max_KeyPress(object sender, KeyPressEventArgs e)
		{
			if((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
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

		private void textBox_variable_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (radioButton_InHouse.Checked)
				{
					if((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
					{
						e.Handled = false;
					}
					else
					{
						MessageBox.Show("Enter a numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						textBox_variable.Clear();
						e.Handled = true;
					}
				}
				else
				{
					if(e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
					{
						e.Handled = true;
						base.OnKeyPress(e);
						MessageBox.Show("Enter letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						textBox_variable.Clear();
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Incorrect data entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		// END OF VALIDATION ZONE







		private void button_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
			BackToMainForm();
			

		}



	}
}
