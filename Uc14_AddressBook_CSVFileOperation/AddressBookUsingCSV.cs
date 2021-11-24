using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc14_AddressBook_CSVFileOperation
{
    class AddressBookUsingCSV
    {
        public static void CsvSerialise(LinkedList<Contacts> book)
        {
            try
            {
                string path = @"C:\Users\Vishal\source\repos\Uc14_AddressBook_CSVFileOperation\Uc14_AddressBook_CSVFileOperation\CSVFile.csv";
                var writer = new StreamWriter(path);
                CultureInfo cultureInfo = new CultureInfo("en -US");
                var csvWrite = new CsvWriter(writer, cultureInfo);


                csvWrite.WriteRecords(book);
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void CsvDeSerialise()
        {
            string path = @"C:\Users\Vishal\source\repos\Uc14_AddressBook_CSVFileOperation\Uc14_AddressBook_CSVFileOperation\FileOpration\CSVFile.csv";

            StreamReader reader = new StreamReader(path);
            var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture);
            var result = csvRead.GetRecords<Contacts>();
            foreach (Contacts person in result)
            {
                Console.WriteLine("FirstName:{0}\tLastName:{1}\tAddress:{2}\tState:{3}\tZipCode:{4}\tPhoneNumber:{5}\tEmail:{6}", person.firstName, person.lastName, person.address, person.state, person.zip, person.phoneNumber, person.email);
            }

        }
    }
}
