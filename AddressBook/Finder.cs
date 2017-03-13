using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
	class Finder {

		/*Returns collection of contacts found in list*/
		public static IEnumerable<People> findInContacts ( string textTyped, List<People> Contacts ) {

			//Looking for proper contact
			var contactsFound = Contacts.Where(c => c.Name.ToLower().Contains(textTyped.ToLower())
												   || c.Surname.ToLower().Contains(textTyped.ToLower())
												   || c.PhoneNumber.ToLower().Contains(textTyped.ToLower()));


			return contactsFound;

		}



	}
}
