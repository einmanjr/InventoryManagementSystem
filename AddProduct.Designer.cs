namespace C968
{
	partial class AddProduct
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
			this.textBox_Inventory = new System.Windows.Forms.TextBox();
			this.textBox_Price = new System.Windows.Forms.TextBox();
			this.textBox_Max = new System.Windows.Forms.TextBox();
			this.textBox_Min = new System.Windows.Forms.TextBox();
			this.textBox_Search = new System.Windows.Forms.TextBox();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.textBox_ID = new System.Windows.Forms.TextBox();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_Save = new System.Windows.Forms.Button();
			this.label_AddProduct = new System.Windows.Forms.Label();
			this.label_Max = new System.Windows.Forms.Label();
			this.label_Min = new System.Windows.Forms.Label();
			this.label_Price = new System.Windows.Forms.Label();
			this.label_Inventory = new System.Windows.Forms.Label();
			this.label_ID = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			this.Search = new System.Windows.Forms.Button();
			this.button_Delete = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.label_AllCandidateParts = new System.Windows.Forms.Label();
			this.label_AssociatedParts = new System.Windows.Forms.Label();
			this.dataGridView_AssociatedParts = new System.Windows.Forms.DataGridView();
			this.dataGridView_AllParts = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssociatedParts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllParts)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_Inventory
			// 
			this.textBox_Inventory.Location = new System.Drawing.Point(160, 199);
			this.textBox_Inventory.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Inventory.Name = "textBox_Inventory";
			this.textBox_Inventory.Size = new System.Drawing.Size(132, 22);
			this.textBox_Inventory.TabIndex = 37;
			this.textBox_Inventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Inventory_KeyPress);
			// 
			// textBox_Price
			// 
			this.textBox_Price.Location = new System.Drawing.Point(160, 251);
			this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Price.Name = "textBox_Price";
			this.textBox_Price.Size = new System.Drawing.Size(132, 22);
			this.textBox_Price.TabIndex = 36;
			this.textBox_Price.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
			this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
			// 
			// textBox_Max
			// 
			this.textBox_Max.Location = new System.Drawing.Point(160, 318);
			this.textBox_Max.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Max.Name = "textBox_Max";
			this.textBox_Max.Size = new System.Drawing.Size(83, 22);
			this.textBox_Max.TabIndex = 35;
			this.textBox_Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Max_KeyPress);
			// 
			// textBox_Min
			// 
			this.textBox_Min.Location = new System.Drawing.Point(344, 318);
			this.textBox_Min.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Min.Name = "textBox_Min";
			this.textBox_Min.Size = new System.Drawing.Size(83, 22);
			this.textBox_Min.TabIndex = 34;
			this.textBox_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Min_KeyPress);
			// 
			// textBox_Search
			// 
			this.textBox_Search.Location = new System.Drawing.Point(769, 25);
			this.textBox_Search.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Search.Name = "textBox_Search";
			this.textBox_Search.Size = new System.Drawing.Size(195, 22);
			this.textBox_Search.TabIndex = 33;
			// 
			// textBox_Name
			// 
			this.textBox_Name.Location = new System.Drawing.Point(160, 149);
			this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(132, 22);
			this.textBox_Name.TabIndex = 32;
			this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
			// 
			// textBox_ID
			// 
			this.textBox_ID.Location = new System.Drawing.Point(160, 100);
			this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_ID.Name = "textBox_ID";
			this.textBox_ID.Size = new System.Drawing.Size(132, 22);
			this.textBox_ID.TabIndex = 31;
			this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(865, 593);
			this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(100, 28);
			this.button_Cancel.TabIndex = 28;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// button_Save
			// 
			this.button_Save.Location = new System.Drawing.Point(737, 593);
			this.button_Save.Margin = new System.Windows.Forms.Padding(4);
			this.button_Save.Name = "button_Save";
			this.button_Save.Size = new System.Drawing.Size(100, 28);
			this.button_Save.TabIndex = 27;
			this.button_Save.Text = "Save";
			this.button_Save.UseVisualStyleBackColor = true;
			this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
			// 
			// label_AddProduct
			// 
			this.label_AddProduct.AutoSize = true;
			this.label_AddProduct.Location = new System.Drawing.Point(16, 25);
			this.label_AddProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AddProduct.Name = "label_AddProduct";
			this.label_AddProduct.Size = new System.Drawing.Size(86, 17);
			this.label_AddProduct.TabIndex = 26;
			this.label_AddProduct.Text = "Add Product";
			// 
			// label_Max
			// 
			this.label_Max.AutoSize = true;
			this.label_Max.Location = new System.Drawing.Point(85, 326);
			this.label_Max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Max.Name = "label_Max";
			this.label_Max.Size = new System.Drawing.Size(33, 17);
			this.label_Max.TabIndex = 25;
			this.label_Max.Text = "Max";
			// 
			// label_Min
			// 
			this.label_Min.AutoSize = true;
			this.label_Min.Location = new System.Drawing.Point(289, 326);
			this.label_Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Min.Name = "label_Min";
			this.label_Min.Size = new System.Drawing.Size(30, 17);
			this.label_Min.TabIndex = 24;
			this.label_Min.Text = "Min";
			// 
			// label_Price
			// 
			this.label_Price.AutoSize = true;
			this.label_Price.Location = new System.Drawing.Point(59, 261);
			this.label_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Price.Name = "label_Price";
			this.label_Price.Size = new System.Drawing.Size(72, 17);
			this.label_Price.TabIndex = 23;
			this.label_Price.Text = "Price/Cost";
			// 
			// label_Inventory
			// 
			this.label_Inventory.AutoSize = true;
			this.label_Inventory.Location = new System.Drawing.Point(59, 208);
			this.label_Inventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Inventory.Name = "label_Inventory";
			this.label_Inventory.Size = new System.Drawing.Size(66, 17);
			this.label_Inventory.TabIndex = 22;
			this.label_Inventory.Text = "Inventory";
			// 
			// label_ID
			// 
			this.label_ID.AutoSize = true;
			this.label_ID.Location = new System.Drawing.Point(59, 108);
			this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_ID.Name = "label_ID";
			this.label_ID.Size = new System.Drawing.Size(21, 17);
			this.label_ID.TabIndex = 21;
			this.label_ID.Text = "ID";
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(59, 158);
			this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(45, 17);
			this.label_Name.TabIndex = 20;
			this.label_Name.Text = "Name";
			// 
			// Search
			// 
			this.Search.Location = new System.Drawing.Point(643, 21);
			this.Search.Margin = new System.Windows.Forms.Padding(4);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(100, 28);
			this.Search.TabIndex = 38;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// button_Delete
			// 
			this.button_Delete.Location = new System.Drawing.Point(865, 530);
			this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
			this.button_Delete.Name = "button_Delete";
			this.button_Delete.Size = new System.Drawing.Size(100, 28);
			this.button_Delete.TabIndex = 39;
			this.button_Delete.Text = "Delete";
			this.button_Delete.UseVisualStyleBackColor = true;
			this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(865, 263);
			this.button_Add.Margin = new System.Windows.Forms.Padding(4);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(100, 28);
			this.button_Add.TabIndex = 40;
			this.button_Add.Text = "Add";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// label_AllCandidateParts
			// 
			this.label_AllCandidateParts.AutoSize = true;
			this.label_AllCandidateParts.Location = new System.Drawing.Point(511, 52);
			this.label_AllCandidateParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AllCandidateParts.Name = "label_AllCandidateParts";
			this.label_AllCandidateParts.Size = new System.Drawing.Size(128, 17);
			this.label_AllCandidateParts.TabIndex = 41;
			this.label_AllCandidateParts.Text = "All Candidate Parts";
			// 
			// label_AssociatedParts
			// 
			this.label_AssociatedParts.AutoSize = true;
			this.label_AssociatedParts.Location = new System.Drawing.Point(511, 318);
			this.label_AssociatedParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AssociatedParts.Name = "label_AssociatedParts";
			this.label_AssociatedParts.Size = new System.Drawing.Size(221, 17);
			this.label_AssociatedParts.TabIndex = 42;
			this.label_AssociatedParts.Text = "Parts Associated with this Product";
			// 
			// dataGridView_AssociatedParts
			// 
			this.dataGridView_AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_AssociatedParts.Location = new System.Drawing.Point(515, 338);
			this.dataGridView_AssociatedParts.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_AssociatedParts.Name = "dataGridView_AssociatedParts";
			this.dataGridView_AssociatedParts.RowHeadersWidth = 51;
			this.dataGridView_AssociatedParts.Size = new System.Drawing.Size(451, 185);
			this.dataGridView_AssociatedParts.TabIndex = 44;
			this.dataGridView_AssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AssociatedParts_CellClick);
			// 
			// dataGridView_AllParts
			// 
			this.dataGridView_AllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_AllParts.Location = new System.Drawing.Point(515, 71);
			this.dataGridView_AllParts.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_AllParts.Name = "dataGridView_AllParts";
			this.dataGridView_AllParts.RowHeadersWidth = 51;
			this.dataGridView_AllParts.Size = new System.Drawing.Size(451, 185);
			this.dataGridView_AllParts.TabIndex = 45;
			this.dataGridView_AllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllParts_CellClick);
			// 
			// AddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 636);
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
			this.Controls.Add(this.label_AddProduct);
			this.Controls.Add(this.label_Max);
			this.Controls.Add(this.label_Min);
			this.Controls.Add(this.label_Price);
			this.Controls.Add(this.label_Inventory);
			this.Controls.Add(this.label_ID);
			this.Controls.Add(this.label_Name);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddProduct";
			this.Text = "AddProduct";
			this.Load += new System.EventHandler(this.AddProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssociatedParts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllParts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_Inventory;
		private System.Windows.Forms.TextBox textBox_Price;
		private System.Windows.Forms.TextBox textBox_Max;
		private System.Windows.Forms.TextBox textBox_Min;
		private System.Windows.Forms.TextBox textBox_Search;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.TextBox textBox_ID;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Save;
		private System.Windows.Forms.Label label_AddProduct;
		private System.Windows.Forms.Label label_Max;
		private System.Windows.Forms.Label label_Min;
		private System.Windows.Forms.Label label_Price;
		private System.Windows.Forms.Label label_Inventory;
		private System.Windows.Forms.Label label_ID;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.Button button_Delete;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.Label label_AllCandidateParts;
		private System.Windows.Forms.Label label_AssociatedParts;
		private System.Windows.Forms.DataGridView dataGridView_AssociatedParts;
		private System.Windows.Forms.DataGridView dataGridView_AllParts;
	}
}