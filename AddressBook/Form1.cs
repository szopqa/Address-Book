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



		/*Shows only correct contacts != null */
		private void showShowcase ( List<People> conts ) {

			foreach ( People p in conts ) {

				Console.WriteLine("Name : " + p.Name);
				Console.WriteLine("Surname : " + p.Surname);
				Console.WriteLine("Phone n : " + p.PhoneNumber);
				Console.WriteLine("Mail : " + p.EmailAddress);					Console.WriteLine("City : " + p.City);
				Console.WriteLine("Address: " + p.Address);
				Console.WriteLine("Add. info : " + p.AdditionalInfo);
				Console.WriteLine();
				Console.WriteLine(p.EndOfShowcase);
				Console.WriteLine();

			}

		}

		

		/*Adds new (correct) contact to contact list*/
		private void addNewContactToList(People new_person ) {

			if(new_person != null ) {

				Contacts.Add(new_person);

			}

		}





		







		//--------------------BUTTONS MANAGEMENT------------------------
		private void AddNewBtn_Click ( object sender, EventArgs e ) {
			//this.Hide();
			addWindow.ShowDialog();
			addNewContactToList(addWindow.getPerson());
			showShowcase(Contacts);
		}


		private void ShowMoreBtn_Click ( object sender, EventArgs e ) {
			//this.Hide();
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
