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
		}

		private void Edit_form_Load ( object sender, EventArgs e ) {
			showInfoAboutSelected();
			editedContact = null;
		}

		public void getInfoAboutSelected ( People selectedPerson ) {

			if ( selectedPerson != null ) {
				contactToEdit = selectedPerson;
			}

		}

		/*Shows info about contact selected to edit*/
		private void showInfoAboutSelected () {

			NameBox.Text =  contactToEdit.Name;
			SurnameBox.Text =  contactToEdit.Surname;
			PhoneBox.Text =contactToEdit.PhoneNumber;
			MailBox.Text = contactToEdit.EmailAddress;
			CityBox.Text = contactToEdit.City;
			AddressBox.Text = contactToEdit.Address;
			NoteBox.Text = contactToEdit.AdditionalInfo;
			

		}

		/*Methods adds new contact with parameters given by user and removes old contact*/		
		protected override void AddBtn_Click ( object sender, EventArgs e ) {

			base.AddBtn_Click(sender, e);
			editedContact = base.getPerson();


			//The reason why contacts list is a public static field
			MainWindow.Contacts.Remove(contactToEdit);

		}


		public People getPerson () {
			return editedContact;
		}

	}
}
