using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
	public partial class Form1 : Form {

		private List<People> Contacts = new List<People>();

		public Form1 () {
			InitializeComponent();

			//TODO: Load contacts from file to Contacts List

		}


		private void AddNewBtn_Click ( object sender, EventArgs e ) {
			AddNew_form addWindow = new AddNew_form();
			this.Hide();
			addWindow.ShowDialog();
		}

		private void ShowMoreBtn_Click ( object sender, EventArgs e ) {

		}

		private void RemoveBtn_Click( object sender, EventArgs e ) {

		}

		private void SearchBtn_Click( object sender, EventArgs e ) {

		}

		private void SettingsBtn_Click( object sender, EventArgs e) {

		}
	}
}
