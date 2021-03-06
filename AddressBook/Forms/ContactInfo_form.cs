﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
	public partial class ContactInfo_form : Form {


		//TODO: Or if contact is not selected find contact inside, and then show more info
		//Idea: Search button disabled when user selected contact from list, enabled if not

		public bool WasContactEdited { get; set; }

		private People selectedContact = new People();
		private People editedContact;
		private Edit_form editWindow = new Edit_form();



		public ContactInfo_form () {
			InitializeComponent();
		}

	
		
		/*Loads window with adjusted information about selected contact*/
		private void ContactInfo_form_Load ( object sender, EventArgs e ) {
			showInfoAboutSelected();
			editedContact = null;
		}

		/*Copies selected object's properties to local one*/
		public void getInfoAboutSelected(People person) {

			if(person != null ) {

				selectedContact = person;

			}
			
		}

		/*Method executed on window load. Shows contact's details*/
		private void showInfoAboutSelected () {

			NameHeader.Text = selectedContact.Name + " " + selectedContact.Surname;
			PhoneInfo.Text = selectedContact.PhoneNumber;
			MailInfo.Text = selectedContact.EmailAddress;
			CityInfo.Text = selectedContact.City;
			AddressInfo.Text = selectedContact.Address;
			NotesInfo.Text = selectedContact.AdditionalInfo;
			//ISSUE: Too long note wont fit in that text box

		}



		private void backButton_Click ( object sender, EventArgs e ) {
			this.Close();
		}



		private void editBtn_Click ( object sender, EventArgs e ) {


			//Refreshes info about edited contact in EditWindow
			if (editedContact != null ) {
				//Refreshed info about edited contact 
				editWindow.getInfoAboutSelected(editedContact);

			}else {

				editWindow.getInfoAboutSelected(selectedContact);

			}

			editWindow.ShowDialog();




			if(editWindow.getPerson() != null ) {

				//Gets changed People object after edit 

				WasContactEdited = true;
				this.editedContact = editWindow.getPerson();

				refreshWindow();
					
			}
			else {
				//Wrong data typed so nothing changes
				WasContactEdited = false;
			}


		}

		private void refreshWindow () {

			NameHeader.Text = editedContact.Name + " " + selectedContact.Surname;
			PhoneInfo.Text = editedContact.PhoneNumber;
			MailInfo.Text = editedContact.EmailAddress;
			CityInfo.Text = editedContact.City;
			AddressInfo.Text = editedContact.Address;
			NotesInfo.Text = editedContact.AdditionalInfo;

		}



		public People getEditedContact () {
			return editedContact;
		}
	}
}
