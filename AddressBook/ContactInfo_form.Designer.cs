namespace AddressBook {
	partial class ContactInfo_form {
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
			this.SurnameHeader = new System.Windows.Forms.Label();
			this.NameHeader = new System.Windows.Forms.Label();
			this.PhoneHeader = new System.Windows.Forms.Label();
			this.MailHeader = new System.Windows.Forms.Label();
			this.BirthHeader = new System.Windows.Forms.Label();
			this.CityHeader = new System.Windows.Forms.Label();
			this.AddressHeader = new System.Windows.Forms.Label();
			this.NoteHeader = new System.Windows.Forms.Label();
			this.SurnameInfo = new System.Windows.Forms.TextBox();
			this.NameInfo = new System.Windows.Forms.TextBox();
			this.PhoneInfo = new System.Windows.Forms.TextBox();
			this.MailInfo = new System.Windows.Forms.TextBox();
			this.DateInfo = new System.Windows.Forms.TextBox();
			this.CityInfo = new System.Windows.Forms.TextBox();
			this.AddressInfo = new System.Windows.Forms.TextBox();
			this.NotesInfo = new System.Windows.Forms.TextBox();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SurnameHeader
			// 
			this.SurnameHeader.AutoSize = true;
			this.SurnameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.SurnameHeader.Location = new System.Drawing.Point(32, 8);
			this.SurnameHeader.Name = "SurnameHeader";
			this.SurnameHeader.Size = new System.Drawing.Size(110, 25);
			this.SurnameHeader.TabIndex = 0;
			this.SurnameHeader.Text = "Surname: ";
			// 
			// NameHeader
			// 
			this.NameHeader.AutoSize = true;
			this.NameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NameHeader.Location = new System.Drawing.Point(32, 43);
			this.NameHeader.Name = "NameHeader";
			this.NameHeader.Size = new System.Drawing.Size(80, 25);
			this.NameHeader.TabIndex = 0;
			this.NameHeader.Text = "Name: ";
			// 
			// PhoneHeader
			// 
			this.PhoneHeader.AutoSize = true;
			this.PhoneHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PhoneHeader.Location = new System.Drawing.Point(32, 78);
			this.PhoneHeader.Name = "PhoneHeader";
			this.PhoneHeader.Size = new System.Drawing.Size(164, 25);
			this.PhoneHeader.TabIndex = 0;
			this.PhoneHeader.Text = "Phone number: ";
			// 
			// MailHeader
			// 
			this.MailHeader.AutoSize = true;
			this.MailHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.MailHeader.Location = new System.Drawing.Point(32, 113);
			this.MailHeader.Name = "MailHeader";
			this.MailHeader.Size = new System.Drawing.Size(160, 25);
			this.MailHeader.TabIndex = 0;
			this.MailHeader.Text = "Email address: ";
			// 
			// BirthHeader
			// 
			this.BirthHeader.AutoSize = true;
			this.BirthHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.BirthHeader.Location = new System.Drawing.Point(32, 149);
			this.BirthHeader.Name = "BirthHeader";
			this.BirthHeader.Size = new System.Drawing.Size(116, 25);
			this.BirthHeader.TabIndex = 0;
			this.BirthHeader.Text = "Birth date: ";
			// 
			// CityHeader
			// 
			this.CityHeader.AutoSize = true;
			this.CityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CityHeader.Location = new System.Drawing.Point(32, 186);
			this.CityHeader.Name = "CityHeader";
			this.CityHeader.Size = new System.Drawing.Size(61, 25);
			this.CityHeader.TabIndex = 0;
			this.CityHeader.Text = "City: ";
			// 
			// AddressHeader
			// 
			this.AddressHeader.AutoSize = true;
			this.AddressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.AddressHeader.Location = new System.Drawing.Point(32, 221);
			this.AddressHeader.Name = "AddressHeader";
			this.AddressHeader.Size = new System.Drawing.Size(103, 25);
			this.AddressHeader.TabIndex = 0;
			this.AddressHeader.Text = "Address: ";
			// 
			// NoteHeader
			// 
			this.NoteHeader.AutoSize = true;
			this.NoteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.NoteHeader.Location = new System.Drawing.Point(32, 261);
			this.NoteHeader.Name = "NoteHeader";
			this.NoteHeader.Size = new System.Drawing.Size(184, 25);
			this.NoteHeader.TabIndex = 0;
			this.NoteHeader.Text = "Additional notes:  ";
			// 
			// SurnameInfo
			// 
			this.SurnameInfo.Location = new System.Drawing.Point(210, 13);
			this.SurnameInfo.Name = "SurnameInfo";
			this.SurnameInfo.ReadOnly = true;
			this.SurnameInfo.Size = new System.Drawing.Size(244, 20);
			this.SurnameInfo.TabIndex = 1;
			// 
			// NameInfo
			// 
			this.NameInfo.Location = new System.Drawing.Point(210, 48);
			this.NameInfo.Name = "NameInfo";
			this.NameInfo.ReadOnly = true;
			this.NameInfo.Size = new System.Drawing.Size(244, 20);
			this.NameInfo.TabIndex = 1;
			// 
			// PhoneInfo
			// 
			this.PhoneInfo.Location = new System.Drawing.Point(210, 83);
			this.PhoneInfo.Name = "PhoneInfo";
			this.PhoneInfo.ReadOnly = true;
			this.PhoneInfo.Size = new System.Drawing.Size(244, 20);
			this.PhoneInfo.TabIndex = 1;
			// 
			// MailInfo
			// 
			this.MailInfo.Location = new System.Drawing.Point(210, 118);
			this.MailInfo.Name = "MailInfo";
			this.MailInfo.ReadOnly = true;
			this.MailInfo.Size = new System.Drawing.Size(244, 20);
			this.MailInfo.TabIndex = 1;
			// 
			// DateInfo
			// 
			this.DateInfo.Location = new System.Drawing.Point(210, 154);
			this.DateInfo.Name = "DateInfo";
			this.DateInfo.ReadOnly = true;
			this.DateInfo.Size = new System.Drawing.Size(244, 20);
			this.DateInfo.TabIndex = 1;
			// 
			// CityInfo
			// 
			this.CityInfo.Location = new System.Drawing.Point(210, 191);
			this.CityInfo.Name = "CityInfo";
			this.CityInfo.ReadOnly = true;
			this.CityInfo.Size = new System.Drawing.Size(244, 20);
			this.CityInfo.TabIndex = 1;
			// 
			// AddressInfo
			// 
			this.AddressInfo.Location = new System.Drawing.Point(210, 226);
			this.AddressInfo.Name = "AddressInfo";
			this.AddressInfo.ReadOnly = true;
			this.AddressInfo.Size = new System.Drawing.Size(244, 20);
			this.AddressInfo.TabIndex = 1;
			// 
			// NotesInfo
			// 
			this.NotesInfo.Location = new System.Drawing.Point(210, 266);
			this.NotesInfo.Multiline = true;
			this.NotesInfo.Name = "NotesInfo";
			this.NotesInfo.ReadOnly = true;
			this.NotesInfo.Size = new System.Drawing.Size(244, 63);
			this.NotesInfo.TabIndex = 1;
			// 
			// backButton
			// 
			this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.backButton.Location = new System.Drawing.Point(363, 345);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(91, 37);
			this.backButton.TabIndex = 2;
			this.backButton.Text = "OK";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// ContactInfo_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 394);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.NotesInfo);
			this.Controls.Add(this.AddressInfo);
			this.Controls.Add(this.CityInfo);
			this.Controls.Add(this.DateInfo);
			this.Controls.Add(this.MailInfo);
			this.Controls.Add(this.PhoneInfo);
			this.Controls.Add(this.NameInfo);
			this.Controls.Add(this.SurnameInfo);
			this.Controls.Add(this.NoteHeader);
			this.Controls.Add(this.AddressHeader);
			this.Controls.Add(this.CityHeader);
			this.Controls.Add(this.BirthHeader);
			this.Controls.Add(this.MailHeader);
			this.Controls.Add(this.PhoneHeader);
			this.Controls.Add(this.NameHeader);
			this.Controls.Add(this.SurnameHeader);
			this.Name = "ContactInfo_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ContactInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SurnameHeader;
		private System.Windows.Forms.Label NameHeader;
		private System.Windows.Forms.Label PhoneHeader;
		private System.Windows.Forms.Label MailHeader;
		private System.Windows.Forms.Label BirthHeader;
		private System.Windows.Forms.Label CityHeader;
		private System.Windows.Forms.Label AddressHeader;
		private System.Windows.Forms.Label NoteHeader;
		private System.Windows.Forms.TextBox SurnameInfo;
		private System.Windows.Forms.TextBox NameInfo;
		private System.Windows.Forms.TextBox PhoneInfo;
		private System.Windows.Forms.TextBox MailInfo;
		private System.Windows.Forms.TextBox DateInfo;
		private System.Windows.Forms.TextBox CityInfo;
		private System.Windows.Forms.TextBox AddressInfo;
		private System.Windows.Forms.TextBox NotesInfo;
		private System.Windows.Forms.Button backButton;
	}
}