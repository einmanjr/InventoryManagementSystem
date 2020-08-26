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
	public partial class AddPart : Form
	{

        public object PartsBindingSource { get; private set; }  

  







		public bool IsInHouse;

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








		public void BackToMainForm()
		{
			MainForm backtomain = new MainForm();
			this.Hide();
			backtomain.Show();
		}





		public AddPart()
		{
			InitializeComponent();

            textBox_ID.Enabled = false;
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
            if (MessageBox.Show("Are you sure? data will be discarded", "Add Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BackToMainForm();
            }
		}

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
                    if (radioButton_InHouse.Checked)
                    {
                        InHouse newPart = new InHouse
                           ( //Convert.ToInt32(textBox_ID),
                            textBox_Name.Text,
                            Convert.ToDouble(textBox_Price.Text),
                            Convert.ToInt32(textBox_Inventory.Text),
                            Convert.ToInt32(textBox_Max.Text),
                            Convert.ToInt32(textBox_Min.Text),
                            Convert.ToInt32(textBox_variable.Text));

                            Inventory.AddPart(newPart); 
                    }
                    else
                    {
                        Outsourced newPart = new Outsourced
                            (//Convert.ToInt32(textBox_ID),
                            textBox_Name.Text,
                            Convert.ToDouble(textBox_Price.Text),
                            Convert.ToInt32(textBox_Inventory.Text),
                            Convert.ToInt32(textBox_Max.Text),
                            Convert.ToInt32(textBox_Min.Text),
                            Convert.ToString(textBox_variable.Text));

                        Inventory.AddPart(newPart);
                    }
                    BackToMainForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // VALIDATION ZONE -- user input data blah blah blah


        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Name Box should have Letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Enter a numeric value for the Inventory Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Enter a numeric value for Price text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Enter a numeric value for Max text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Enter a numeric value for Min text box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Handled = true;
            }
        }

        private void textBox_variable_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (radioButton_InHouse.Checked)
                {
                    if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        MessageBox.Show("Enter a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox_variable.Clear();
                        e.Handled = true;
                    }
                }
                else
                {
                    if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
                    {
                        e.Handled = true;
                        base.OnKeyPress(e);
                        MessageBox.Show("Enter letters only for the Company Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox_variable.Clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect data entry", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
   
    // END OF VALIDATION ZONE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    
    
    }
	
}
