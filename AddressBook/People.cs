using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook {
	public class People {

		/*Number of all contacts created*/
		public static int Amount { get; set; }

		public int ID { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string FullName { get; set; } //Name + Surname, need that to show in contacts list
		public string BirthDate { get; set; }
		public string PhoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
		public string AdditionalInfo { get; set; } //note or sth
		public static string EndOfShowcase { get; set; } //Every contact will end up with couple of "-" signs
		
		/*Default parameters*/
		public People () {

			//TODO: Birth date handle
			Amount++;
			ID = Amount;	//setting unique id for every new object
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
