using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
	public partial class Form1 : Form {

		//PROPERTIES
		private List<People> Contacts = new List<People>();
		private AddNew_form addWindow = new AddNew_form ();
		private ContactInfo_form moreInfoWindow = new ContactInfo_form();
		private DataManager data = new DataManager ();
		private bool addedSuccessfully;

		public Form1 () {

			InitializeComponent();
			
		}

		private void Form1_Load ( object sender, EventArgs e ) {

			data.createDataFolder();
			data.checkIfContsXmlExists();

			Contacts = data.loadContactsFromXml();

			updateContactsList();

			//TODO: Sort them by Surname's first letter

		}



		//--------------------BUTTONS MANAGEMENT------------------------

		private void AddNewBtn_Click ( object sender, EventArgs e ) {
			//this.Hide();
			addWindow.ShowDialog();
			addedSuccessfully = addNewContactToList(addWindow.getPerson());

			if(addedSuccessfully == true ) {

				showShowcase(Contacts);
				updateContactsList();
				data.saveContactsToXML(Contacts);

			}
		}


		private void ShowMoreBtn_Click ( object sender, EventArgs e ) {
			moreInfoWindow.ShowDialog();
		}

		private void RemoveBtn_Click( object sender, EventArgs e ) {

		}

		private void SearchBtn_Click( object sender, EventArgs e ) {

		}

		private void SettingsBtn_Click( object sender, EventArgs e) {

		}


		
		/*	Handles item select
		 *	Getting FullName property, to select appropriate object
		 */
		private void listBox1_SelectedIndexChanged ( object sender, EventArgs e ) {

			//ISSUE: It wont work if there will be two contacts with same name and surname
			//TODO: Have to create unique id for every contact

			People selectedContact = new People();

			string fullNameOfSelected =" ";

			try {

				fullNameOfSelected = ContactsList.SelectedItem.ToString();

			}catch(NullReferenceException) {
				MessageBox.Show("Select contact");
			}

			foreach(People contact in Contacts ) {



				if ( contact.FullName.Equals(fullNameOfSelected) ) {
					selectedContact = contact;
				}

			}
			

			//passing selected object
			moreInfoWindow.getInfoAboutSelected(selectedContact);


					/*
					var selectedContact = ContactsList.SelectedItem as People;

					People fittingContact = new People();

					foreach(People contact in Contacts ) {
						if ( contact.ID.Equals(selectedContact.ID) ) {
							fittingContact = contact;
						}
					}

					moreInfoWindow.getInfoAboutSelected(fittingContact);
					*/

		}








		//-------------------FUNCTIONAL METHODS-------------------------

		/*Shows only correct contacts != null */
		private void showShowcase ( List<People> conts ) {

			Console.Clear();

			foreach ( People p in conts ) {
				Console.WriteLine("ID : " + p.ID);
				Console.WriteLine("Name : " + p.Name);
				Console.WriteLine("Surname : " + p.Surname);
				Console.WriteLine("Phone n : " + p.PhoneNumber);
				Console.WriteLine("Mail : " + p.EmailAddress);
				Console.WriteLine("City : " + p.City);
				Console.WriteLine("Address: " + p.Address);
				Console.WriteLine("Add. info : " + p.AdditionalInfo);
				Console.WriteLine();
				Console.WriteLine(People.EndOfShowcase);
				Console.WriteLine();

			}

		}

		/*Refreshes list, sorts contacts by their surname*/
		private void updateContactsList () {

			ContactsList.Items.Clear();


			//Sort List by Surname's first letter
			sortContactsInList(ref Contacts);


			foreach (People person in Contacts ) {

				ContactsList.Items.Add(person.FullName);

			}

		}


		private void sortContactsInList (ref List<People> listToSort) {

			listToSort = listToSort.OrderBy(t => t.Surname).ToList();		
				
		}


		/*Adds new (correct - != null) contact to contact list*/
		private bool addNewContactToList ( People new_person ) {

			if ( new_person != null ) {

				Contacts.Add(new_person);
				return true;

			}

			else
				return false;
		}
		

		//----------------END OF FUNCTIONAL METHODS---------------------

	}
}
