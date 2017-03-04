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
	public partial class ContactInfo_form : Form {


		public ContactInfo_form () {
			InitializeComponent();
		}


		private void showInfoAboutSelected(People person ) {
			
			//TODO: Or if contact is not selected find contact inside, and then show more info
			//Idea: Search button disabled when user selected contact from list, enabled if not

		}

		
	}
}
