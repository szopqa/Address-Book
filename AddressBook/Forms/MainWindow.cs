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
	public partial class MainWindow: Form {

		
		#region Properties
		private AddNew_form addWindow = new AddNew_form ();
		private ContactInfo_form moreInfoWindow = new ContactInfo_form();
		private Edit_form editWindow = new Edit_form();

		public static List<People> Contacts = new List<People>();
		private DataManager data = new DataManager ();
		private People selectedContact = new People();
		#endregion


		public MainWindow () {

			InitializeComponent();
			
		}

		private void Form1_Load ( object sender, EventArgs e ) {

			data.createDataFolder();
			data.checkIfContsXmlExists();
	
			//Onload loads all contacts from XML datafile
			Contacts = data.loadContactsFromXml();

			updateContactsList();

		}



		//--------------------BUTTONS MANAGEMENT------------------------

		private void AddNewBtn_Click ( object sender, EventArgs e ) {

			bool addedSuccessfully;

			addWindow.ShowDialog();
			addedSuccessfully = addNewContactToList(addWindow.getPerson());

			if(addedSuccessfully == true ) {

				updateContactsList();
				data.saveContactsToXML(Contacts);

			}


		}

		/*Function shows more info about selected contact in new window, in which
		 * user can edit selected contact.
		 * 
		 * Param	wasContactEdited specifies whether contact was edited inside moreInfo window
		 *If yes it edits chosen contact
		 *If no, nothing changes
		 */
		private void ShowMoreBtn_Click ( object sender, EventArgs e ) {

			bool wasContactEdited;

			moreInfoWindow.getInfoAboutSelected(selectedContact);
			moreInfoWindow.ShowDialog();

			wasContactEdited = moreInfoWindow.WasContactEdited;

			if ( wasContactEdited ) {
				addNewContactToList(moreInfoWindow.getEditedContact());
				updateContactsList();
				
				data.saveContactsToXML(Contacts);
			}

		}


		private void RemoveBtn_Click( object sender, EventArgs e ) {

			DialogResult res = 
				MessageBox.Show("Are you sure?","From deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
			if(res == DialogResult.Yes ) {

				Contacts.Remove(selectedContact);
			
				updateContactsList();
			
				//Updates file after deleting contact
				data.saveContactsToXML(Contacts);

			}

		}



		/*Shows "Search" button when user type something*/
		private void searchBox_TextChanged ( object sender, EventArgs e ) {

			if ( !string.IsNullOrWhiteSpace(searchBox.Text) ) {

				SearchBtn.Visible = true;

			}else {

				updateContactsList();
				SearchBtn.Visible = false;

			}

		}

		private void SearchBtn_Click( object sender, EventArgs e ) {

			string textTyped = searchBox.Text;
			var contactsFound = Finder.findInContacts(textTyped,Contacts);

			updateContactsListAfterSearch(contactsFound);
					

		}
		

		private void ContactsList_MouseDoubleClick (object sender, MouseEventArgs e) {

			//TODO : Doubleckick will show more info about contact
			
		}



		private void editBtn_Click(object sender, EventArgs e ) {

			bool editedSuccessfully;

			editWindow.getInfoAboutSelected(selectedContact);
			editWindow.ShowDialog();
			
			editedSuccessfully = addNewContactToList(editWindow.getPerson());

			if ( editedSuccessfully == true ) {

				updateContactsList();
				data.saveContactsToXML(Contacts);

			}

		}

		private void SettingsBtn_Click( object sender, EventArgs e) {

		}


		
		/*	Handles item select
		 *	Getting FullName property, to select appropriate object
		 *	returns selected contact to class
		 */
		private void listBox1_SelectedIndexChanged ( object sender, EventArgs e ) {

			//ISSUE: It wont work if there will be two contacts with same name and surname
			//TODO: Have to create unique id for every contact

			string fullNameOfSelected =" ";

			try {

				fullNameOfSelected = ContactsList.SelectedItem.ToString();

			}catch(NullReferenceException) {
				MessageBox.Show("Select contact");
			}

			foreach(People contact in Contacts ) {

				if ( contact.FullName.Equals(fullNameOfSelected) ) {
					this.selectedContact = contact;
				}
				
			}
			
		}








		//-------------------FUNCTIONAL METHODS-------------------------


		/*Refreshes list, sorts contacts by their surname*/
		private void updateContactsList () {

			ContactsList.Items.Clear();


			//Sort List by Surname's first letter
			sortContactsInList(ref Contacts);


			foreach (People person in Contacts ) {

				ContactsList.Items.Add(person.FullName);

			}

		}


		/*Updates contact list after searching*/
		private void updateContactsListAfterSearch (IEnumerable<People> found) {


			ContactsList.Items.Clear();


			if(found.Count() == 0 ) {

				ContactsList.Items.Add("Not found");

			}else {

				List<People> contactsFound = found.ToList();


				sortContactsInList(ref contactsFound);

				foreach ( People person in contactsFound ) {

					ContactsList.Items.Add(person.FullName);

				}
				
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

	}
}
