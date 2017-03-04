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

		//PROPERTIES
		private List<People> Contacts = new List<People>();
		private AddNew_form addWindow = new AddNew_form();




		public Form1 () {
			InitializeComponent();

			//TODO: Load contacts from file to Contacts List
			//TODO: Sort them by Surname's first letter

		}


		private void AddNewBtn_Click ( object sender, EventArgs e ) {
			this.Hide();
			addWindow.ShowDialog();
		}


		private void AddNewContactToList(People new_person ) {
			Contacts.Add(addWindow.Person);
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
