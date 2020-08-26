namespace C968
{
	partial class MainForm
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
			this.label_InventoryManagementSystem = new System.Windows.Forms.Label();
			this.label_Parts = new System.Windows.Forms.Label();
			this.label_Products = new System.Windows.Forms.Label();
			this.button_Parts_Search = new System.Windows.Forms.Button();
			this.button_Products_Search = new System.Windows.Forms.Button();
			this.button_Products_Delete = new System.Windows.Forms.Button();
			this.button_Products_Modify = new System.Windows.Forms.Button();
			this.button_Products_Add = new System.Windows.Forms.Button();
			this.button_Exit = new System.Windows.Forms.Button();
			this.button_Parts_Delete = new System.Windows.Forms.Button();
			this.button_Parts_Modify = new System.Windows.Forms.Button();
			this.button_Parts_Add = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.textBox_Parts_Search = new System.Windows.Forms.TextBox();
			this.textBox_Products_Search = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// label_InventoryManagementSystem
			// 
			this.label_InventoryManagementSystem.AutoSize = true;
			this.label_InventoryManagementSystem.Location = new System.Drawing.Point(37, 36);
			this.label_InventoryManagementSystem.Name = "label_InventoryManagementSystem";
			this.label_InventoryManagementSystem.Size = new System.Drawing.Size(202, 17);
			this.label_InventoryManagementSystem.TabIndex = 0;
			this.label_InventoryManagementSystem.Text = "Inventory Management System";
			// 
			// label_Parts
			// 
			this.label_Parts.AutoSize = true;
			this.label_Parts.Location = new System.Drawing.Point(60, 187);
			this.label_Parts.Name = "label_Parts";
			this.label_Parts.Size = new System.Drawing.Size(41, 17);
			this.label_Parts.TabIndex = 1;
			this.label_Parts.Text = "Parts";
			// 
			// label_Products
			// 
			this.label_Products.AutoSize = true;
			this.label_Products.Location = new System.Drawing.Point(709, 187);
			this.label_Products.Name = "label_Products";
			this.label_Products.Size = new System.Drawing.Size(64, 17);
			this.label_Products.TabIndex = 2;
			this.label_Products.Text = "Products";
			// 
			// button_Parts_Search
			// 
			this.button_Parts_Search.Location = new System.Drawing.Point(269, 146);
			this.button_Parts_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Parts_Search.Name = "button_Parts_Search";
			this.button_Parts_Search.Size = new System.Drawing.Size(89, 23);
			this.button_Parts_Search.TabIndex = 3;
			this.button_Parts_Search.Text = "Search";
			this.button_Parts_Search.UseVisualStyleBackColor = true;
			this.button_Parts_Search.Click += new System.EventHandler(this.button_Parts_Search_Click);
			// 
			// button_Products_Search
			// 
			this.button_Products_Search.Location = new System.Drawing.Point(928, 146);
			this.button_Products_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Products_Search.Name = "button_Products_Search";
			this.button_Products_Search.Size = new System.Drawing.Size(89, 23);
			this.button_Products_Search.TabIndex = 4;
			this.button_Products_Search.Text = "Search";
			this.button_Products_Search.UseVisualStyleBackColor = true;
			this.button_Products_Search.Click += new System.EventHandler(this.button_Products_Search_Click);
			// 
			// button_Products_Delete
			// 
			this.button_Products_Delete.Location = new System.Drawing.Point(1185, 410);
			this.button_Products_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Products_Delete.Name = "button_Products_Delete";
			this.button_Products_Delete.Size = new System.Drawing.Size(89, 23);
			this.button_Products_Delete.TabIndex = 5;
			this.button_Products_Delete.Text = "Delete";
			this.button_Products_Delete.UseVisualStyleBackColor = true;
			this.button_Products_Delete.Click += new System.EventHandler(this.button_Products_Delete_Click);
			// 
			// button_Products_Modify
			// 
			this.button_Products_Modify.Location = new System.Drawing.Point(1091, 410);
			this.button_Products_Modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Products_Modify.Name = "button_Products_Modify";
			this.button_Products_Modify.Size = new System.Drawing.Size(89, 23);
			this.button_Products_Modify.TabIndex = 6;
			this.button_Products_Modify.Text = "Modify";
			this.button_Products_Modify.UseVisualStyleBackColor = true;
			this.button_Products_Modify.Click += new System.EventHandler(this.button_Products_Modify_Click);
			// 
			// button_Products_Add
			// 
			this.button_Products_Add.Location = new System.Drawing.Point(996, 410);
			this.button_Products_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Products_Add.Name = "button_Products_Add";
			this.button_Products_Add.Size = new System.Drawing.Size(89, 23);
			this.button_Products_Add.TabIndex = 7;
			this.button_Products_Add.Text = "Add";
			this.button_Products_Add.UseVisualStyleBackColor = true;
			this.button_Products_Add.Click += new System.EventHandler(this.button_Products_Add_Click);
			// 
			// button_Exit
			// 
			this.button_Exit.Location = new System.Drawing.Point(1155, 570);
			this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Exit.Name = "button_Exit";
			this.button_Exit.Size = new System.Drawing.Size(89, 23);
			this.button_Exit.TabIndex = 8;
			this.button_Exit.Text = "Exit";
			this.button_Exit.UseVisualStyleBackColor = true;
			this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
			// 
			// button_Parts_Delete
			// 
			this.button_Parts_Delete.Location = new System.Drawing.Point(524, 410);
			this.button_Parts_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Parts_Delete.Name = "button_Parts_Delete";
			this.button_Parts_Delete.Size = new System.Drawing.Size(89, 23);
			this.button_Parts_Delete.TabIndex = 9;
			this.button_Parts_Delete.Text = "Delete";
			this.button_Parts_Delete.UseVisualStyleBackColor = true;
			this.button_Parts_Delete.Click += new System.EventHandler(this.button_Parts_Delete_Click);
			// 
			// button_Parts_Modify
			// 
			this.button_Parts_Modify.Location = new System.Drawing.Point(429, 410);
			this.button_Parts_Modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Parts_Modify.Name = "button_Parts_Modify";
			this.button_Parts_Modify.Size = new System.Drawing.Size(89, 23);
			this.button_Parts_Modify.TabIndex = 10;
			this.button_Parts_Modify.Text = "Modify";
			this.button_Parts_Modify.UseVisualStyleBackColor = true;
			this.button_Parts_Modify.Click += new System.EventHandler(this.button_Parts_Modify_Click);
			// 
			// button_Parts_Add
			// 
			this.button_Parts_Add.Location = new System.Drawing.Point(335, 410);
			this.button_Parts_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_Parts_Add.Name = "button_Parts_Add";
			this.button_Parts_Add.Size = new System.Drawing.Size(89, 23);
			this.button_Parts_Add.TabIndex = 11;
			this.button_Parts_Add.Text = "Add";
			this.button_Parts_Add.UseVisualStyleBackColor = true;
			this.button_Parts_Add.Click += new System.EventHandler(this.button_Parts_Add_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(64, 206);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(549, 188);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(713, 206);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(557, 188);
			this.dataGridView2.TabIndex = 13;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
			// 
			// textBox_Parts_Search
			// 
			this.textBox_Parts_Search.Location = new System.Drawing.Point(365, 146);
			this.textBox_Parts_Search.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Parts_Search.Name = "textBox_Parts_Search";
			this.textBox_Parts_Search.Size = new System.Drawing.Size(247, 22);
			this.textBox_Parts_Search.TabIndex = 14;
			// 
			// textBox_Products_Search
			// 
			this.textBox_Products_Search.Location = new System.Drawing.Point(1024, 149);
			this.textBox_Products_Search.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Products_Search.Name = "textBox_Products_Search";
			this.textBox_Products_Search.Size = new System.Drawing.Size(244, 22);
			this.textBox_Products_Search.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 634);
			this.Controls.Add(this.textBox_Products_Search);
			this.Controls.Add(this.textBox_Parts_Search);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button_Parts_Add);
			this.Controls.Add(this.button_Parts_Modify);
			this.Controls.Add(this.button_Parts_Delete);
			this.Controls.Add(this.button_Exit);
			this.Controls.Add(this.button_Products_Add);
			this.Controls.Add(this.button_Products_Modify);
			this.Controls.Add(this.button_Products_Delete);
			this.Controls.Add(this.button_Products_Search);
			this.Controls.Add(this.button_Parts_Search);
			this.Controls.Add(this.label_Products);
			this.Controls.Add(this.label_Parts);
			this.Controls.Add(this.label_InventoryManagementSystem);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_InventoryManagementSystem;
		private System.Windows.Forms.Label label_Parts;
		private System.Windows.Forms.Label label_Products;
		private System.Windows.Forms.Button button_Parts_Search;
		private System.Windows.Forms.Button button_Products_Search;
		private System.Windows.Forms.Button button_Products_Delete;
		private System.Windows.Forms.Button button_Products_Modify;
		private System.Windows.Forms.Button button_Products_Add;
		private System.Windows.Forms.Button button_Exit;
		private System.Windows.Forms.Button button_Parts_Delete;
		private System.Windows.Forms.Button button_Parts_Modify;
		private System.Windows.Forms.Button button_Parts_Add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox textBox_Parts_Search;
		private System.Windows.Forms.TextBox textBox_Products_Search;
	}
}

