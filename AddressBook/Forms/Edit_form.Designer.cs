namespace AddressBook {
	partial class Edit_form {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_form));
			this.SuspendLayout();
			// 
			// AddBtn
			// 
			this.AddBtn.BackColor = System.Drawing.Color.Teal;
			this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
			this.AddBtn.Location = new System.Drawing.Point(245, 280);
			this.AddBtn.Size = new System.Drawing.Size(88, 70);
			this.AddBtn.Text = "";
			this.AddBtn.UseVisualStyleBackColor = false;
			// 
			// Edit_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(572, 353);
			this.Name = "Edit_form";
			this.Text = "Edit";
			this.Load += new System.EventHandler(this.Edit_form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}
