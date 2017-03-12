using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddressBook {
	public partial class Edit_form : AddNew_form {

		private People contactToEdit = new People();
		private People editedContact = new People();


		public Edit_form () {
			InitializeComponent();
			AddBtn.Text = "Save changes";
			editedContact = null;
		}

		private void Edit_form_Load ( object sender, EventArgs e ) {
			showInfoAboutSelected();
		}

		public void getInfoAboutSelected ( People p ) {

			if ( p != null ) {
				contactToEdit = p;
			}

		}

		/*Shows info about contact selected to edit*/
		private void showInfoAboutSelected () {

			NameBox.Text = (string) contactToEdit.Name;
			SurnameBox.Text =(string) contactToEdit.Surname;
			PhoneBox.Text =(string)contactToEdit.PhoneNumber;
			MailBox.Text = (string)contactToEdit.EmailAddress;
			CityBox.Text = (string)contactToEdit.City;
			AddressBox.Text =(string) contactToEdit.Address;
			NoteBox.Text = (string)contactToEdit.AdditionalInfo;
			

		}

		/*Methods adds new contact with parameters given by user and removes old contact*/		
		protected override void AddBtn_Click ( object sender, EventArgs e ) {

			base.AddBtn_Click(sender, e);
			editedContact = base.getPerson();

			Form1.Contacts.Remove(contactToEdit);

		}


		public People getPerson () {
			return editedContact;
		}

	}
}
