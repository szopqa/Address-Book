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
	public partial class AddNew_form : Form {

		People person = new People();

		public People new_person {
			get { return person; }
			set {
				person = value;
			}
		}

		public AddNew_form () {
			InitializeComponent();
		}

		private void AddBtn_Click ( object sender, EventArgs e ) {

			person.Name = NameBox.Text;
			person.Surname = SurnameBox.Text;
			person.BirthDate = DateBox.Text;
			person.PhoneNumber = PhoneBox.Text;
			person.EmailAddress = MailBox.Text;
			person.City = CityBox.Text;
			person.Address = AddressBox.Text;
			person.AditionalInfo = NoteBox.Text;

		}
	}
}
