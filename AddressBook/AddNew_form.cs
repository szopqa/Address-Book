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
			SurnameBox.Clear();
			NameBox.Clear();
			PhoneBox.Clear();
			MailBox.Clear();
			CityBox.Clear();
			AddressBox.Clear();
			NoteBox.Clear();
		}



		private void AddBtn_Click ( object sender, EventArgs e ) {

			People Person = new People();

				Person.Surname = SurnameBox.Text;
				Person.Name = NameBox.Text;
				Person.BirthDate = DateBox.Text;
				Person.PhoneNumber = PhoneBox.Text;
				Person.EmailAddress = MailBox.Text;
				Person.City = CityBox.Text;
				Person.Address = AddressBox.Text;
				Person.AdditionalInfo = NoteBox.Text;


			newContact = Person;

			People.ID++;	

			//TODO: Checking if filled correctly


			/* First idea to check if all boxes are filled
			 
		
			foreach(Control c in this.Controls ) {
				if(c is TextBox ) {
					TextBox textBox = c as TextBox;

					if (textBox.Text == string.Empty && textBox.Name != "NoteBox" ) {
						MessageBox.Show("Insert all Data!");
						this.Refresh();
					}

					else if(textBox.Text == string.Empty && textBox.Name == "NoteBox" ) {
						NoteBox.Text = "No additional info\n";
					}

					else {
						newContact = Person;
					}
				}
			}


			*/


			this.Close();
		}

		/*Second idea to check if filled correctly*/
		private void CheckIfFilledCorectly(People per ) {

			foreach(var prop in per.GetType().GetProperties() ) {
				if(prop.GetValue(per) == string.Empty ) {
					Console.WriteLine("Empty!!!!");
					this.newContact = null;
				}
				else {
					this.newContact = per;
				}
			}

		}


		public People getPerson () {
			return newContact;
		}

	}
}
