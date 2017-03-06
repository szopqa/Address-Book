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

	/*
	 *	User enters new contact informations into text boxes
	 *	Then informations are returned as Person's object properties
	 */

	public partial class AddNew_form : Form {


		private People newContact = new People();

		public AddNew_form () {
			InitializeComponent();
		}


		private void AddNew_form_Load ( object sender, EventArgs e ) {
			clearAllBoxes();
			newContact = null;
		}






		/* 
		 * Name, Phone number: 
		 * Those two parameters have to be filled to create a new contact
		 * 
		 * Sets newContact object as null if values are incorrect
		 */
		private void AddBtn_Click ( object sender, EventArgs e ) {

			if(	string.IsNullOrWhiteSpace(NameBox.Text) 
				||
				string.IsNullOrWhiteSpace(SurnameBox.Text) 
				&& 
				string.IsNullOrWhiteSpace(PhoneBox.Text) ) {

				newContact = null;
				MessageBox.Show("\"Name\" and \"Phone number\" fields have to be filled!");
				clearAllBoxes();

			}
			else {

				People person = new People();

				person.Surname = SurnameBox.Text;
				person.Name = NameBox.Text;
				person.FullName = NameBox.Text + " " + SurnameBox.Text;
				person.BirthDate = DateBox.Text;
				person.PhoneNumber = PhoneBox.Text;
				person.EmailAddress = MailBox.Text;
				person.City = CityBox.Text;
				person.Address = AddressBox.Text;
				person.AdditionalInfo = NoteBox.Text;

				newContact = person;
				clearAllBoxes();
				this.Close();

			}

		}

		/*Clears all TextBoxes */
		private void clearAllBoxes () {
			SurnameBox.Clear();
			NameBox.Clear();
			PhoneBox.Clear();
			MailBox.Clear();
			CityBox.Clear();
			AddressBox.Clear();
			NoteBox.Clear();
		}
		
		/*Returns null if user filled boxes wrong*/
		public People getPerson () {

			return newContact;

		}

	}
}
