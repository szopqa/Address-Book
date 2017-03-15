namespace AddressBook {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.ContactsGroupBox = new System.Windows.Forms.GroupBox();
			this.ContactsList = new System.Windows.Forms.ListBox();
			this.ShowMoreBtn = new System.Windows.Forms.Button();
			this.RemoveBtn = new System.Windows.Forms.Button();
			this.exportBtn = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.editBtn = new System.Windows.Forms.Button();
			this.searchGroupBox = new System.Windows.Forms.GroupBox();
			this.AddNewBtn = new System.Windows.Forms.Button();
			this.ContactsGroupBox.SuspendLayout();
			this.searchGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContactsGroupBox
			// 
			this.ContactsGroupBox.BackColor = System.Drawing.Color.DarkCyan;
			this.ContactsGroupBox.Controls.Add(this.ContactsList);
			this.ContactsGroupBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ContactsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ContactsGroupBox.Name = "ContactsGroupBox";
			this.ContactsGroupBox.Size = new System.Drawing.Size(323, 376);
			this.ContactsGroupBox.TabIndex = 0;
			this.ContactsGroupBox.TabStop = false;
			this.ContactsGroupBox.Text = "Contacts";
			// 
			// ContactsList
			// 
			this.ContactsList.BackColor = System.Drawing.Color.LightSlateGray;
			this.ContactsList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ContactsList.FormattingEnabled = true;
			this.ContactsList.ItemHeight = 22;
			this.ContactsList.Location = new System.Drawing.Point(26, 39);
			this.ContactsList.Name = "ContactsList";
			this.ContactsList.Size = new System.Drawing.Size(270, 312);
			this.ContactsList.TabIndex = 0;
			this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// ShowMoreBtn
			// 
			this.ShowMoreBtn.BackColor = System.Drawing.Color.SlateGray;
			this.ShowMoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ShowMoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowMoreBtn.Image")));
			this.ShowMoreBtn.Location = new System.Drawing.Point(495, 110);
			this.ShowMoreBtn.Name = "ShowMoreBtn";
			this.ShowMoreBtn.Size = new System.Drawing.Size(95, 95);
			this.ShowMoreBtn.TabIndex = 2;
			this.ShowMoreBtn.UseVisualStyleBackColor = false;
			this.ShowMoreBtn.Click += new System.EventHandler(this.ShowMoreBtn_Click);
			// 
			// RemoveBtn
			// 
			this.RemoveBtn.BackColor = System.Drawing.Color.SlateGray;
			this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.Image")));
			this.RemoveBtn.Location = new System.Drawing.Point(495, 248);
			this.RemoveBtn.Name = "RemoveBtn";
			this.RemoveBtn.Size = new System.Drawing.Size(95, 95);
			this.RemoveBtn.TabIndex = 3;
			this.RemoveBtn.UseVisualStyleBackColor = false;
			this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
			// 
			// exportBtn
			// 
			this.exportBtn.BackColor = System.Drawing.Color.SlateGray;
			this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
			this.exportBtn.Location = new System.Drawing.Point(341, 20);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.Size = new System.Drawing.Size(53, 45);
			this.exportBtn.TabIndex = 5;
			this.exportBtn.UseVisualStyleBackColor = false;
			this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(6, 21);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(182, 26);
			this.searchBox.TabIndex = 6;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// editBtn
			// 
			this.editBtn.BackColor = System.Drawing.Color.SlateGray;
			this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
			this.editBtn.Location = new System.Drawing.Point(364, 248);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(95, 95);
			this.editBtn.TabIndex = 7;
			this.editBtn.UseVisualStyleBackColor = false;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Controls.Add(this.searchBox);
			this.searchGroupBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.searchGroupBox.Location = new System.Drawing.Point(409, 12);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(194, 53);
			this.searchGroupBox.TabIndex = 8;
			this.searchGroupBox.TabStop = false;
			this.searchGroupBox.Text = "Search";
			// 
			// AddNewBtn
			// 
			this.AddNewBtn.BackColor = System.Drawing.Color.SlateGray;
			this.AddNewBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddNewBtn.Image")));
			this.AddNewBtn.Location = new System.Drawing.Point(364, 110);
			this.AddNewBtn.Name = "AddNewBtn";
			this.AddNewBtn.Size = new System.Drawing.Size(95, 95);
			this.AddNewBtn.TabIndex = 9;
			this.AddNewBtn.UseVisualStyleBackColor = false;
			this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(615, 397);
			this.Controls.Add(this.AddNewBtn);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.exportBtn);
			this.Controls.Add(this.RemoveBtn);
			this.Controls.Add(this.ShowMoreBtn);
			this.Controls.Add(this.ContactsGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Address Book";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ContactsGroupBox.ResumeLayout(false);
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox ContactsGroupBox;
		private System.Windows.Forms.Button ShowMoreBtn;
		private System.Windows.Forms.Button RemoveBtn;
		private System.Windows.Forms.Button exportBtn;
		private System.Windows.Forms.ListBox ContactsList;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.Button AddNewBtn;
	}
}

