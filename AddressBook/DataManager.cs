using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace AddressBook {
	class DataManager {


		public string Filename { get; set; }
		public string PathFolder { get; set; }
		public string VCFpath { get; set; }

		private bool VCFsaveResult;
		private int vCardVersion;




		public DataManager () {
			
			/*User/AppData/Address Book Data*/
			PathFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			
			/*Saving Vcard to desktop as default*/
			VCFpath = Environment.GetFolderPath( System.Environment.SpecialFolder.DesktopDirectory) 
					+ "\\AddressBook_contacts.vcf";

			VCFsaveResult = false;

			vCardVersion = 1; //used if file exists, then adds for example _1 at the end 
		}



		public void createDataFolder () {

			if ( !Directory.Exists(PathFolder + "\\Address Book Data") ) {
				Directory.CreateDirectory(PathFolder + "\\Address Book Data");
			}
		}

		public void checkIfContsXmlExists () {

			if(!File.Exists(PathFolder + "\\Address Book Data\\data.xml") ) {
				XmlTextWriter xWrite = new XmlTextWriter(PathFolder + "\\Address Book Data\\data.xml", Encoding.UTF8);
				xWrite.WriteStartElement("Contacts");
				xWrite.WriteEndElement();
				xWrite.Close();
			}

		}


		/*Saves all objects from list to XML File located in %appdata% folder */
		public void saveContactsToXML (List<People> contacts) {

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(PathFolder + "\\Address Book Data\\data.xml");

			XmlNode xNode = xmlDoc.SelectSingleNode("Contacts");
			xNode.RemoveAll();

			foreach(People person in contacts ) {

				XmlNode xmlTitle = xmlDoc.CreateElement("Contact");
				XmlNode xmlID = xmlDoc.CreateElement("ID");
				XmlNode xmlFullName = xmlDoc.CreateElement("FullName");
				XmlNode xmlBirthDate = xmlDoc.CreateElement("BirthDate");
				XmlNode xmlName = xmlDoc.CreateElement("Name");
				XmlNode xmlSurname = xmlDoc.CreateElement("Surname");
				XmlNode xmlPhoneNumber = xmlDoc.CreateElement("PhoneNumber");
				XmlNode xmlEmailAddress = xmlDoc.CreateElement("EmailAddress");
				XmlNode xmlCity = xmlDoc.CreateElement("City");
				XmlNode xmlAddress = xmlDoc.CreateElement("Address");
				XmlNode xmlAdditionalInfo = xmlDoc.CreateElement("AdditionalInfo");


				xmlID.InnerText = person.ID.ToString();
				xmlFullName.InnerText = person.FullName;
				xmlBirthDate.InnerText = person.BirthDate;
				xmlName.InnerText = person.Name;
				xmlSurname.InnerText = person.Surname;
				xmlPhoneNumber.InnerText = person.PhoneNumber;
				xmlEmailAddress.InnerText = person.EmailAddress;
				xmlCity.InnerText = person.City;
				xmlAddress.InnerText = person.Address;
				xmlAdditionalInfo.InnerText = person.AdditionalInfo;

				xmlTitle.AppendChild(xmlID);
				xmlTitle.AppendChild(xmlFullName);
				xmlTitle.AppendChild(xmlBirthDate);
				xmlTitle.AppendChild(xmlName);
				xmlTitle.AppendChild(xmlSurname);
				xmlTitle.AppendChild(xmlPhoneNumber);
				xmlTitle.AppendChild(xmlEmailAddress);
				xmlTitle.AppendChild(xmlCity);
				xmlTitle.AppendChild(xmlAddress);
				xmlTitle.AppendChild(xmlAdditionalInfo);

				xmlDoc.DocumentElement.AppendChild(xmlTitle);

			}

			xmlDoc.Save(PathFolder + "\\Address Book Data\\data.xml");
		}


		public List<People> loadContactsFromXml () {

			XmlDocument xmlDoc = new XmlDocument();
			List<People> contacts = new List<People>();
			xmlDoc.Load(PathFolder + "\\Address Book Data\\data.xml");

			foreach(XmlNode xNode in xmlDoc.SelectNodes("Contacts/Contact") ) {

				People person = new People();

				person.ID =int.Parse(xNode.SelectSingleNode("ID").InnerText);
				person.FullName = xNode.SelectSingleNode("FullName").InnerText;
				person.BirthDate = xNode.SelectSingleNode("BirthDate").InnerText;
				person.Name = xNode.SelectSingleNode("Name").InnerText;
				person.Surname = xNode.SelectSingleNode("Surname").InnerText;
				person.PhoneNumber = xNode.SelectSingleNode("PhoneNumber").InnerText;
				person.EmailAddress = xNode.SelectSingleNode("EmailAddress").InnerText;
				person.City = xNode.SelectSingleNode("City").InnerText;
				person.Address = xNode.SelectSingleNode("Address").InnerText;
				person.AdditionalInfo = xNode.SelectSingleNode("AdditionalInfo").InnerText;

				contacts.Add(person);
					
			}


			return contacts;
		}
		


		public void exportToVCF (List<People> ContactsToExport) {

			StringBuilder vcf = new StringBuilder();		
			

			foreach(People contact in ContactsToExport ) {


				vcf.Append("BEGIN:VCARD" + System.Environment.NewLine);
				vcf.Append("VERSION:3.0" + System.Environment.NewLine);
				vcf.Append("N:" + contact.Surname + ";" + contact.Name + System.Environment.NewLine);
				vcf.Append("FN:" + contact.FullName + System.Environment.NewLine);
				vcf.Append("TEL;CELL:" + contact.PhoneNumber + System.Environment.NewLine);
				vcf.Append("EMAIL;TYPE=INTERNET:" + contact.EmailAddress + System.Environment.NewLine);
				vcf.Append("END:VCARD" + System.Environment.NewLine);

			}


			//TODO : If file exists adds for eg _1 at the end of the filename
			/*
			if( File.Exists( VCFpath ) ) {


				int index = VCFpath.IndexOf(".vcf");

				VCFpath.Insert(index - 1, "_" + vCardVersion.ToString());

				vCardVersion++;
			}
			*/

			try {

				File.WriteAllText( VCFpath , vcf.ToString() );
				VCFsaveResult = true;
			}
			catch ( Exception ex ) {

				VCFsaveResult = false;

			}
			
		}



		public bool VCFsaveSucceed () {

			return VCFsaveResult;
			
		}

	}
}
