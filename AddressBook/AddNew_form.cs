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
			
			/*Name and Phone Number fields have to be passed to create new contact*/
			bool isPhoneNumberEmpty = string.IsNullOrWhiteSpace(PhoneBox.Text);
			bool isNameEmpty = string.IsNullOrWhiteSpace(NameBox.Text);
			bool isSurnameEmpty = string.IsNullOrWhiteSpace(SurnameBox.Text);


			if ( isPhoneNumberEmpty == true || isNameEmpty == true ) {

				newContact = null;
				MessageBox.Show("\"Name\" and \"Phone number\" fields have to be filled!");
				clearAllBoxes();

			}

			else if ( !isNumeric(PhoneBox.Text) ) {
				MessageBox.Show("Type correct phone number!");
				newContact = null;
				PhoneBox.Clear();
			}

			else if ( !isMailCorrect(MailBox.Text) ) {
				MessageBox.Show("Type correct Email Address!");
				newContact = null;
				MailBox.Clear();
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

		private bool isMailCorrect (string strTyped) {

			bool isCorrect = false;

			if(strTyped.Contains(".") && strTyped.Contains("@") || string.IsNullOrWhiteSpace(strTyped)) {
				isCorrect = true;
			}

			return isCorrect;

		}


		/*Checks if user typed phone number as string numbers*/
		private bool isNumeric (string strTyped) {


			bool isNum = false;
			bool hadPlusSign = false;


			if ( strTyped.Contains("+") ) {

				int count = strTyped.Count(t => t == '+');
				
				if(count > 1 ) {

					return false;

				}else {
					strTyped = strTyped.Replace("+", string.Empty);
					hadPlusSign = true;
				}

			}

			//Checking if string without + is a number
			double PhoneNumber;
			isNum = Double.TryParse(strTyped, out PhoneNumber);

			if(isNum == true && hadPlusSign == false ) {
				return true;
			}

			else if(isNum== true && hadPlusSign == true ) {
				return true;
			}

			else {
				return false;
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
