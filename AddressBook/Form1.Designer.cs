﻿namespace AddressBook {
	partial class Form1 {
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
			this.ContactsGroupBox = new System.Windows.Forms.GroupBox();
			this.ContactsList = new System.Windows.Forms.ListBox();
			this.AddNewBtn = new System.Windows.Forms.Button();
			this.ShowMoreBtn = new System.Windows.Forms.Button();
			this.RemoveBtn = new System.Windows.Forms.Button();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.SettingsBtn = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.ContactsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContactsGroupBox
			// 
			this.ContactsGroupBox.Controls.Add(this.ContactsList);
			this.ContactsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ContactsGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ContactsGroupBox.Name = "ContactsGroupBox";
			this.ContactsGroupBox.Size = new System.Drawing.Size(290, 306);
			this.ContactsGroupBox.TabIndex = 0;
			this.ContactsGroupBox.TabStop = false;
			this.ContactsGroupBox.Text = "Contacts";
			// 
			// ContactsList
			// 
			this.ContactsList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ContactsList.FormattingEnabled = true;
			this.ContactsList.ItemHeight = 17;
			this.ContactsList.Location = new System.Drawing.Point(17, 22);
			this.ContactsList.Name = "ContactsList";
			this.ContactsList.Size = new System.Drawing.Size(257, 276);
			this.ContactsList.TabIndex = 0;
			this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// AddNewBtn
			// 
			this.AddNewBtn.Location = new System.Drawing.Point(341, 91);
			this.AddNewBtn.Name = "AddNewBtn";
			this.AddNewBtn.Size = new System.Drawing.Size(150, 40);
			this.AddNewBtn.TabIndex = 1;
			this.AddNewBtn.Text = "Add new contact";
			this.AddNewBtn.UseVisualStyleBackColor = true;
			this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
			// 
			// ShowMoreBtn
			// 
			this.ShowMoreBtn.Location = new System.Drawing.Point(341, 165);
			this.ShowMoreBtn.Name = "ShowMoreBtn";
			this.ShowMoreBtn.Size = new System.Drawing.Size(150, 40);
			this.ShowMoreBtn.TabIndex = 2;
			this.ShowMoreBtn.Text = "Show more details";
			this.ShowMoreBtn.UseVisualStyleBackColor = true;
			this.ShowMoreBtn.Click += new System.EventHandler(this.ShowMoreBtn_Click);
			// 
			// RemoveBtn
			// 
			this.RemoveBtn.Location = new System.Drawing.Point(341, 240);
			this.RemoveBtn.Name = "RemoveBtn";
			this.RemoveBtn.Size = new System.Drawing.Size(150, 40);
			this.RemoveBtn.TabIndex = 3;
			this.RemoveBtn.Text = "Remove from list";
			this.RemoveBtn.UseVisualStyleBackColor = true;
			this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
			// 
			// SearchBtn
			// 
			this.SearchBtn.Location = new System.Drawing.Point(493, 34);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(68, 30);
			this.SearchBtn.TabIndex = 4;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Visible = false;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// SettingsBtn
			// 
			this.SettingsBtn.Location = new System.Drawing.Point(507, 294);
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new System.Drawing.Size(54, 24);
			this.SettingsBtn.TabIndex = 5;
			this.SettingsBtn.Text = "Settings";
			this.SettingsBtn.UseVisualStyleBackColor = true;
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(341, 40);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(150, 20);
			this.searchBox.TabIndex = 6;
			this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 326);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.SettingsBtn);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.RemoveBtn);
			this.Controls.Add(this.ShowMoreBtn);
			this.Controls.Add(this.AddNewBtn);
			this.Controls.Add(this.ContactsGroupBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ContactsGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox ContactsGroupBox;
		private System.Windows.Forms.Button AddNewBtn;
		private System.Windows.Forms.Button ShowMoreBtn;
		private System.Windows.Forms.Button RemoveBtn;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.Button SettingsBtn;
		private System.Windows.Forms.ListBox ContactsList;
		private System.Windows.Forms.TextBox searchBox;
	}
}

