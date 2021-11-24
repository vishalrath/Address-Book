using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc15_AddressBook_JSONFileOpration
{
    class AddressBookUsingJson
    {
        public static void JsonSerializeAddressBook(List<Contacts> contacts)
        {
            string jsonPath = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\JSONFile.json";

            string result = JsonConvert.SerializeObject(contacts);

            File.WriteAllText(jsonPath, result);
        }

        public static void JsonDeserializeAddressBook()
        {
            try
            {
                string path = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\JSONFile.json";
                string result = File.ReadAllText(path);

                Contacts res = JsonConvert.DeserializeObject<Contacts>(result);
                // LinkedList<ContactList> res = JsonConvert.DeserializeObject<LinkedList<ContactList>>(result);

                if (res != null)
                {
                    Console.WriteLine("contact details Using Deserialise Method");
                    Console.WriteLine("FirstName={0}\tLastName={1}\tAddress={2}\tState={3}\tZipcode={4}\tPhoneNumber={5}\tEmail={6}", res.firstName, res.lastName, res.address, res.state, res.zip, res.phoneNumber, res.email);

                }
                else
                {
                    Console.WriteLine("no contact");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
