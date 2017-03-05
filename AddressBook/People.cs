using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
	public class People {


		public static int ID { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string BirthDate { get; set; }
		public string PhoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string AdditionalInfo { get; set; } //note or sth
		public string EndOfShowcase { get; set; } //Every contact will end up with couple of "-" signs
		

		/*Default parameters*/
		public People () {

			//TODO: Birth date handle

			ID++;
			Surname = " ";
			Name = " ";
			BirthDate = " ";
			PhoneNumber = " ";
			EmailAddress = " ";
			City = " ";
			Address = " ";
			AdditionalInfo = "No additional info";
			EndOfShowcase = "------------------------------";
		}

	}

}
