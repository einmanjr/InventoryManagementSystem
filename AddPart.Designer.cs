namespace C968
{
	partial class AddPart
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_AddPart = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			this.label_ID = new System.Windows.Forms.Label();
			this.label_Inventory = new System.Windows.Forms.Label();
			this.label_Price = new System.Windows.Forms.Label();
			this.label_Min = new System.Windows.Forms.Label();
			this.label_Max = new System.Windows.Forms.Label();
			this.variable = new System.Windows.Forms.Label();
			this.button_Save = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.radioButton_InHouse = new System.Windows.Forms.RadioButton();
			this.radioButton_Outsourced = new System.Windows.Forms.RadioButton();
			this.textBox_ID = new System.Windows.Forms.TextBox();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.textBox_variable = new System.Windows.Forms.TextBox();
			this.textBox_Min = new System.Windows.Forms.TextBox();
			this.textBox_Max = new System.Windows.Forms.TextBox();
			this.textBox_Price = new System.Windows.Forms.TextBox();
			this.textBox_Inventory = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label_AddPart
			// 
			this.label_AddPart.AutoSize = true;
			this.label_AddPart.Location = new System.Drawing.Point(16, 11);
			this.label_AddPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AddPart.Name = "label_AddPart";
			this.label_AddPart.Size = new System.Drawing.Size(63, 17);
			this.label_AddPart.TabIndex = 0;
			this.label_AddPart.Text = "Add Part";
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(171, 181);
			this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(45, 17);
			this.label_Name.TabIndex = 1;
			this.label_Name.Text = "Name";
			// 
			// label_ID
			// 
			this.label_ID.AutoSize = true;
			this.label_ID.Location = new System.Drawing.Point(171, 132);
			this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_ID.Name = "label_ID";
			this.label_ID.Size = new System.Drawing.Size(21, 17);
			this.label_ID.TabIndex = 2;
			this.label_ID.Text = "ID";
			// 
			// label_Inventory
			// 
			this.label_Inventory.AutoSize = true;
			this.label_Inventory.Location = new System.Drawing.Point(171, 231);
			this.label_Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Inventory.Name = "label_Inventory";
			this.label_Inventory.Size = new System.Drawing.Size(66, 17);
			this.label_Inventory.TabIndex = 3;
			this.label_Inventory.Text = "Inventory";
			// 
			// label_Price
			// 
			this.label_Price.AutoSize = true;
			this.label_Price.Location = new System.Drawing.Point(171, 284);
			this.label_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Price.Name = "label_Price";
			this.label_Price.Size = new System.Drawing.Size(72, 17);
			this.label_Price.TabIndex = 4;
			this.label_Price.Text = "Price/Cost";
			// 
			// label_Min
			// 
			this.label_Min.AutoSize = true;
			this.label_Min.Location = new System.Drawing.Point(401, 350);
			this.label_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Min.Name = "label_Min";
			this.label_Min.Size = new System.Drawing.Size(30, 17);
			this.label_Min.TabIndex = 5;
			this.label_Min.Text = "Min";
			// 
			// label_Max
			// 
			this.label_Max.AutoSize = true;
			this.label_Max.Location = new System.Drawing.Point(197, 350);
			this.label_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Max.Name = "label_Max";
			this.label_Max.Size = new System.Drawing.Size(33, 17);
			this.label_Max.TabIndex = 6;
			this.label_Max.Text = "Max";
			// 
			// variable
			// 
			this.variable.AutoSize = true;
			this.variable.Location = new System.Drawing.Point(171, 421);
			this.variable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.variable.Name = "variable";
			this.variable.Size = new System.Drawing.Size(74, 17);
			this.variable.TabIndex = 7;
			this.variable.Text = "variable??";
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(305, 481);
			this.button_Save.Margin = new System.Windows.Forms.Padding(4);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(100, 28);
			this.button_Save.TabIndex = 8;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(440, 481);
			this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(100, 28);
			this.button_Cancel.TabIndex = 9;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// radioButton_InHouse
			// 
			this.radioButton_InHouse.AutoSize = true;
			this.radioButton_InHouse.Location = new System.Drawing.Point(196, 52);
			this.radioButton_InHouse.Margin = new System.Windows.Forms.Padding(4);
			this.radioButton_InHouse.Name = "radioButton_InHouse";
			this.radioButton_InHouse.Size = new System.Drawing.Size(86, 21);
			this.radioButton_InHouse.TabIndex = 10;
			this.radioButton_InHouse.TabStop = true;
			this.radioButton_InHouse.Text = "In-House";
			this.radioButton_InHouse.UseVisualStyleBackColor = true;
			this.radioButton_InHouse.CheckedChanged += new System.EventHandler(this.radioButton_InHouse_CheckedChanged);
			// 
			// radioButton_Outsourced
			// 
			this.radioButton_Outsourced.AutoSize = true;
			this.radioButton_Outsourced.Location = new System.Drawing.Point(348, 52);
			this.radioButton_Outsourced.Margin = new System.Windows.Forms.Padding(4);
			this.radioButton_Outsourced.Name = "radioButton_Outsourced";
			this.radioButton_Outsourced.Size = new System.Drawing.Size(103, 21);
			this.radioButton_Outsourced.TabIndex = 11;
			this.radioButton_Outsourced.TabStop = true;
			this.radioButton_Outsourced.Text = "Outsourced";
			this.radioButton_Outsourced.UseVisualStyleBackColor = true;
			this.radioButton_Outsourced.CheckedChanged += new System.EventHandler(this.radioButton_Outsourced_CheckedChanged);
			// 
			// textBox_ID
			// 
			this.textBox_ID.Location = new System.Drawing.Point(272, 123);
			this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_ID.Name = "textBox_ID";
			this.textBox_ID.Size = new System.Drawing.Size(132, 22);
			this.textBox_ID.TabIndex = 12;
			// 
			// textBox_Name
			// 
			this.textBox_Name.Location = new System.Drawing.Point(272, 172);
			this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(132, 22);
			this.textBox_Name.TabIndex = 13;
			this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
			// 
			// textBox_variable
			// 
			this.textBox_variable.Location = new System.Drawing.Point(272, 412);
			this.textBox_variable.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_variable.Name = "textBox_variable";
			this.textBox_variable.Size = new System.Drawing.Size(132, 22);
			this.textBox_variable.TabIndex = 14;
			this.textBox_variable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_variable_KeyPress);
			// 
			// textBox_Min
			// 
			this.textBox_Min.Location = new System.Drawing.Point(456, 341);
			this.textBox_Min.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Min.Name = "textBox_Min";
			this.textBox_Min.Size = new System.Drawing.Size(83, 22);
			this.textBox_Min.TabIndex = 15;
			this.textBox_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Min_KeyPress);
			// 
			// textBox_Max
			// 
			this.textBox_Max.Location = new System.Drawing.Point(272, 341);
			this.textBox_Max.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Max.Name = "textBox_Max";
			this.textBox_Max.Size = new System.Drawing.Size(83, 22);
			this.textBox_Max.TabIndex = 16;
			this.textBox_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Max_KeyPress);
			// 
			// textBox_Price
			// 
			this.textBox_Price.Location = new System.Drawing.Point(272, 274);
			this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Price.Name = "textBox_Price";
			this.textBox_Price.Size = new System.Drawing.Size(132, 22);
			this.textBox_Price.TabIndex = 17;
			this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
			// 
			// textBox_Inventory
			// 
			this.textBox_Inventory.Location = new System.Drawing.Point(272, 223);
			this.textBox_Inventory.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Inventory.Name = "textBox_Inventory";
			this.textBox_Inventory.Size = new System.Drawing.Size(132, 22);
			this.textBox_Inventory.TabIndex = 18;
			this.textBox_Inventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Inventory_KeyPress);
			// 
			// AddPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 554);
			this.Controls.Add(this.textBox_Inventory);
			this.Controls.Add(this.textBox_Price);
			this.Controls.Add(this.textBox_Max);
			this.Controls.Add(this.textBox_Min);
			this.Controls.Add(this.textBox_variable);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.textBox_ID);
			this.Controls.Add(this.radioButton_Outsourced);
			this.Controls.Add(this.radioButton_InHouse);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.variable);
			this.Controls.Add(this.label_Max);
			this.Controls.Add(this.label_Min);
			this.Controls.Add(this.label_Price);
			this.Controls.Add(this.label_Inventory);
			this.Controls.Add(this.label_ID);
			this.Controls.Add(this.label_Name);
			this.Controls.Add(this.label_AddPart);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddPart";
			this.Text = "AddPart";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_AddPart;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.Label label_ID;
		private System.Windows.Forms.Label label_Inventory;
		private System.Windows.Forms.Label label_Price;
		private System.Windows.Forms.Label label_Min;
		private System.Windows.Forms.Label label_Max;
		private System.Windows.Forms.Label variable;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.RadioButton radioButton_InHouse;
		private System.Windows.Forms.RadioButton radioButton_Outsourced;
		private System.Windows.Forms.TextBox textBox_ID;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.TextBox textBox_variable;
		private System.Windows.Forms.TextBox textBox_Min;
		private System.Windows.Forms.TextBox textBox_Max;
		private System.Windows.Forms.TextBox textBox_Price;
		private System.Windows.Forms.TextBox textBox_Inventory;
	}
}