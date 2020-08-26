namespace C968
{
	partial class ModifyProduct
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
			this.dataGridView_AllParts = new System.Windows.Forms.DataGridView();
			this.dataGridView_AssociatedParts = new System.Windows.Forms.DataGridView();
			this.label_AssociatedParts = new System.Windows.Forms.Label();
			this.label_AllCandidateParts = new System.Windows.Forms.Label();
			this.button_Add = new System.Windows.Forms.Button();
			this.button_Delete = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Button();
			this.textBox_Inventory = new System.Windows.Forms.TextBox();
			this.textBox_Price = new System.Windows.Forms.TextBox();
			this.textBox_Max = new System.Windows.Forms.TextBox();
			this.textBox_Min = new System.Windows.Forms.TextBox();
			this.textBox_Search = new System.Windows.Forms.TextBox();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.textBox_ID = new System.Windows.Forms.TextBox();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_Save = new System.Windows.Forms.Button();
			this.label_ModifyProduct = new System.Windows.Forms.Label();
			this.label_Max = new System.Windows.Forms.Label();
			this.label_Min = new System.Windows.Forms.Label();
			this.label_Price = new System.Windows.Forms.Label();
			this.label_Inventory = new System.Windows.Forms.Label();
			this.label_ID = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllParts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssociatedParts)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_AllParts
			// 
			this.dataGridView_AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_AllParts.Location = new System.Drawing.Point(508, 65);
			this.dataGridView_AllParts.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_AllParts.Name = "dataGridView_AllParts";
			this.dataGridView_AllParts.RowHeadersWidth = 51;
			this.dataGridView_AllParts.Size = new System.Drawing.Size(451, 185);
			this.dataGridView_AllParts.TabIndex = 68;
			this.dataGridView_AllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllParts_CellClick);
			// 
			// dataGridView_AssociatedParts
			// 
			this.dataGridView_AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_AssociatedParts.Location = new System.Drawing.Point(508, 332);
			this.dataGridView_AssociatedParts.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_AssociatedParts.Name = "dataGridView_AssociatedParts";
			this.dataGridView_AssociatedParts.RowHeadersWidth = 51;
			this.dataGridView_AssociatedParts.Size = new System.Drawing.Size(451, 185);
			this.dataGridView_AssociatedParts.TabIndex = 67;
			this.dataGridView_AssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AssociatedParts_CellClick);
			// 
			// label_AssociatedParts
			// 
			this.label_AssociatedParts.AutoSize = true;
			this.label_AssociatedParts.Location = new System.Drawing.Point(504, 311);
			this.label_AssociatedParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AssociatedParts.Name = "label_AssociatedParts";
			this.label_AssociatedParts.Size = new System.Drawing.Size(221, 17);
			this.label_AssociatedParts.TabIndex = 66;
			this.label_AssociatedParts.Text = "Parts Associated with this Product";
			// 
			// label_AllCandidateParts
			// 
			this.label_AllCandidateParts.AutoSize = true;
			this.label_AllCandidateParts.Location = new System.Drawing.Point(504, 46);
			this.label_AllCandidateParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AllCandidateParts.Name = "label_AllCandidateParts";
			this.label_AllCandidateParts.Size = new System.Drawing.Size(128, 17);
			this.label_AllCandidateParts.TabIndex = 65;
			this.label_AllCandidateParts.Text = "All Candidate Parts";
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(859, 257);
			this.button_Add.Margin = new System.Windows.Forms.Padding(4);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(100, 28);
			this.button_Add.TabIndex = 64;
			this.button_Add.Text = "Add";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// button_Delete
			// 
			this.button_Delete.Location = new System.Drawing.Point(859, 524);
			this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
			this.button_Delete.Name = "button_Delete";
			this.button_Delete.Size = new System.Drawing.Size(100, 28);
			this.button_Delete.TabIndex = 63;
			this.button_Delete.Text = "Delete";
			this.button_Delete.UseVisualStyleBackColor = true;
			this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
			// 
			// Search
			// 
			this.Search.Location = new System.Drawing.Point(636, 15);
			this.Search.Margin = new System.Windows.Forms.Padding(4);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(100, 28);
			this.Search.TabIndex = 62;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// textBox_Inventory
			// 
			this.textBox_Inventory.Location = new System.Drawing.Point(153, 193);
			this.textBox_Inventory.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Inventory.Name = "textBox_Inventory";
			this.textBox_Inventory.Size = new System.Drawing.Size(132, 22);
			this.textBox_Inventory.TabIndex = 61;
			// 
			// textBox_Price
			// 
			this.textBox_Price.Location = new System.Drawing.Point(153, 245);
			this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Price.Name = "textBox_Price";
			this.textBox_Price.Size = new System.Drawing.Size(132, 22);
			this.textBox_Price.TabIndex = 60;
			// 
			// textBox_Max
			// 
			this.textBox_Max.Location = new System.Drawing.Point(153, 311);
			this.textBox_Max.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Max.Name = "textBox_Max";
			this.textBox_Max.Size = new System.Drawing.Size(83, 22);
			this.textBox_Max.TabIndex = 59;
			// 
			// textBox_Min
			// 
			this.textBox_Min.Location = new System.Drawing.Point(337, 311);
			this.textBox_Min.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Min.Name = "textBox_Min";
			this.textBox_Min.Size = new System.Drawing.Size(83, 22);
			this.textBox_Min.TabIndex = 58;
			// 
			// textBox_Search
			// 
			this.textBox_Search.Location = new System.Drawing.Point(763, 18);
			this.textBox_Search.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Search.Name = "textBox_Search";
			this.textBox_Search.Size = new System.Drawing.Size(195, 22);
			this.textBox_Search.TabIndex = 57;
			// 
			// textBox_Name
			// 
			this.textBox_Name.Location = new System.Drawing.Point(153, 143);
			this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(132, 22);
			this.textBox_Name.TabIndex = 56;
			// 
			// textBox_ID
			// 
			this.textBox_ID.Location = new System.Drawing.Point(153, 94);
			this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_ID.Name = "textBox_ID";
			this.textBox_ID.Size = new System.Drawing.Size(132, 22);
			this.textBox_ID.TabIndex = 55;
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(859, 587);
			this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(100, 28);
			this.button_Cancel.TabIndex = 54;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(731, 587);
			this.button_Save.Margin = new System.Windows.Forms.Padding(4);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(100, 28);
			this.button_Save.TabIndex = 53;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// label_ModifyProduct
			// 
			this.label_ModifyProduct.AutoSize = true;
			this.label_ModifyProduct.Location = new System.Drawing.Point(9, 18);
			this.label_ModifyProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_ModifyProduct.Name = "label_ModifyProduct";
			this.label_ModifyProduct.Size = new System.Drawing.Size(102, 17);
			this.label_ModifyProduct.TabIndex = 52;
			this.label_ModifyProduct.Text = "Modify Product";
			// 
			// label_Max
			// 
			this.label_Max.AutoSize = true;
			this.label_Max.Location = new System.Drawing.Point(79, 320);
			this.label_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Max.Name = "label_Max";
			this.label_Max.Size = new System.Drawing.Size(33, 17);
			this.label_Max.TabIndex = 51;
			this.label_Max.Text = "Max";
			// 
			// label_Min
			// 
			this.label_Min.AutoSize = true;
			this.label_Min.Location = new System.Drawing.Point(283, 320);
			this.label_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Min.Name = "label_Min";
			this.label_Min.Size = new System.Drawing.Size(30, 17);
			this.label_Min.TabIndex = 50;
			this.label_Min.Text = "Min";
			// 
			// label_Price
			// 
			this.label_Price.AutoSize = true;
			this.label_Price.Location = new System.Drawing.Point(52, 255);
			this.label_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Price.Name = "label_Price";
			this.label_Price.Size = new System.Drawing.Size(72, 17);
			this.label_Price.TabIndex = 49;
			this.label_Price.Text = "Price/Cost";
			// 
			// label_Inventory
			// 
			this.label_Inventory.AutoSize = true;
			this.label_Inventory.Location = new System.Drawing.Point(52, 202);
			this.label_Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Inventory.Name = "label_Inventory";
			this.label_Inventory.Size = new System.Drawing.Size(66, 17);
			this.label_Inventory.TabIndex = 48;
			this.label_Inventory.Text = "Inventory";
			// 
			// label_ID
			// 
			this.label_ID.AutoSize = true;
			this.label_ID.Location = new System.Drawing.Point(52, 102);
			this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_ID.Name = "label_ID";
			this.label_ID.Size = new System.Drawing.Size(21, 17);
			this.label_ID.TabIndex = 47;
			this.label_ID.Text = "ID";
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(52, 151);
			this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(45, 17);
			this.label_Name.TabIndex = 46;
			this.label_Name.Text = "Name";
			// 
			// ModifyProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 693);
			this.Controls.Add(this.dataGridView_AllParts);
			this.Controls.Add(this.dataGridView_AssociatedParts);
			this.Controls.Add(this.label_AssociatedParts);
			this.Controls.Add(this.label_AllCandidateParts);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.button_Delete);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.textBox_Inventory);
			this.Controls.Add(this.textBox_Price);
			this.Controls.Add(this.textBox_Max);
			this.Controls.Add(this.textBox_Min);
			this.Controls.Add(this.textBox_Search);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.textBox_ID);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_Save);
			this.Controls.Add(this.label_ModifyProduct);
			this.Controls.Add(this.label_Max);
			this.Controls.Add(this.label_Min);
			this.Controls.Add(this.label_Price);
			this.Controls.Add(this.label_Inventory);
			this.Controls.Add(this.label_ID);
			this.Controls.Add(this.label_Name);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ModifyProduct";
			this.Text = "ModifyProduct";
			this.Load += new System.EventHandler(this.ModifyProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllParts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssociatedParts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_AllParts;
		private System.Windows.Forms.DataGridView dataGridView_AssociatedParts;
		private System.Windows.Forms.Label label_AssociatedParts;
		private System.Windows.Forms.Label label_AllCandidateParts;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.TextBox textBox_Inventory;
		private System.Windows.Forms.TextBox textBox_Price;
		private System.Windows.Forms.TextBox textBox_Max;
		private System.Windows.Forms.TextBox textBox_Min;
		private System.Windows.Forms.TextBox textBox_Search;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.TextBox textBox_ID;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Label label_ModifyProduct;
		private System.Windows.Forms.Label label_Max;
		private System.Windows.Forms.Label label_Min;
		private System.Windows.Forms.Label label_Price;
		private System.Windows.Forms.Label label_Inventory;
		private System.Windows.Forms.Label label_ID;
		private System.Windows.Forms.Label label_Name;
	}
}