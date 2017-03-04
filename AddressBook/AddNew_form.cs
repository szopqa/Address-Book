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


		public People Person { get; set; }



		public AddNew_form () {
			InitializeComponent();
		}


		private void AddBtn_Click ( object sender, EventArgs e ) {

			Person.Surname = SurnameBox.Text;
			Person.Name = NameBox.Text;
			Person.BirthDate = DateBox.Text;
			Person.PhoneNumber = PhoneBox.Text;
			Person.EmailAddress = MailBox.Text;
			Person.City = CityBox.Text;
			Person.Address = AddressBox.Text;
			Person.AditionalInfo = NoteBox.Text;

		}


	}
}
