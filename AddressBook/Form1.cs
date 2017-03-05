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
		private ContactInfo_form moreInfoWindow = new ContactInfo_form();


		public Form1 () {
			InitializeComponent();

			//TODO: Load contacts from file to Contacts List
			//TODO: Sort them by Surname's first letter

		}

		




		/*Adds new contact to contact list*/
		private void addNewContactToList(People new_person ) {
			Contacts.Add(new_person);
		}








		//--------------------BUTTONS MANAGEMENT------------------------
		private void AddNewBtn_Click ( object sender, EventArgs e ) {
			//this.Hide();
			addWindow.ShowDialog();
			addNewContactToList(addWindow.getPerson());
			Show(Contacts);
		}

		private void Show(List<People> conts ) {

			foreach ( People p in conts ) {
				Console.WriteLine(p.Name);
				Console.WriteLine(p.Surname);
				Console.WriteLine(p.Address);
				Console.WriteLine(p.City);
				Console.WriteLine(p.AdditionalInfo);
			}

		}

		private void ShowMoreBtn_Click ( object sender, EventArgs e ) {
			this.Hide();
			moreInfoWindow.ShowDialog();
		}

		private void RemoveBtn_Click( object sender, EventArgs e ) {

		}

		private void SearchBtn_Click( object sender, EventArgs e ) {

		}

		private void SettingsBtn_Click( object sender, EventArgs e) {

		}

		private void listBox1_SelectedIndexChanged ( object sender, EventArgs e ) {
			ContactsList.DataSource = Contacts;
		}
	}
}
