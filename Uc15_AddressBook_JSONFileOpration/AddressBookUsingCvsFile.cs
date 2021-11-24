using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc15_AddressBook_JSONFileOpration
{
    class AddressBookUsingCvsFile
    {
        //UC USING Csv FILE 
        public static void CsvSerialise(List<Contacts> contacts)
        {
            try
            {
                string path = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\CsvFile.csv";
                var writer = new StreamWriter(path);
                CultureInfo cultureInfo = new CultureInfo("en -US");
                var csvWrite = new CsvWriter(writer, cultureInfo);


                csvWrite.WriteRecords(contacts);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void CsvDeSerialise()
        {
            string path1 = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\CsvFile.csv";

            StreamReader reader = new StreamReader(path1);
            var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture);
            var result = csvRead.GetRecords<Contacts>();
            foreach (Contacts person in result)
            {
                Console.WriteLine("FirstName:{0}\tLastName:{1}\tAddress:{2}\tState:{3}\tZipCode:{4}\tPhoneNumber:{5}\tEmail:{6}", person.firstName, person.lastName, person.address, person.state, person.zip, person.phoneNumber, person.email);
            }

        }
    }
}
