using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc15_AddressBook_JSONFileOpration
{
    class AddressBook
    {

        //declaring a list with the class Contacts as the type
        //declaring adictionary with the already declared list inside of it as the value pair
        public static List<Contacts> contact = new List<Contacts>();
        //public HashSet<string> cityList = new HashSet<string>();
        //public HashSet<string> stateList = new HashSet<string>();
        //the citybook and statebook dictionaries are basically to store person details along with key as city/state 
        public static Dictionary<string, List<Contacts>> cityBook = new Dictionary<string, List<Contacts>>();
        public static Dictionary<string, List<Contacts>> stateBook = new Dictionary<string, List<Contacts>>();
        public static Dictionary<string, List<Contacts>> addressBook = new Dictionary<string, List<Contacts>>();
        //declaring it static so that we dont need to create an object in the program.cs
        public static void AddTo(string name)              //this method is used to pass the new address book name to the dictionary
        {
            addressBook.Add(name, contact);
        }

        public void AddAddress()
        {
            //creating a new object contactBook of the class Contacts to add addressess
            Contacts contactBook = new Contacts();
            Console.Write("Enter First Name - ");
            contactBook.firstName = Console.ReadLine();
            Console.Write("Enter Last Name - ");
            contactBook.lastName = Console.ReadLine();
            Console.Write("Enter Address - ");
            contactBook.address = Console.ReadLine();
            Console.Write("Enter Phone number - ");
            contactBook.phoneNumber = Console.ReadLine();
            Console.Write("Enter Email ID - ");
            contactBook.email = Console.ReadLine();
            Console.Write("Enter City - ");
            contactBook.city = Console.ReadLine();
            Console.Write("Enter State - ");
            contactBook.state = Console.ReadLine();
            Console.Write("Enter ZIP code - ");
            contactBook.zip = Console.ReadLine();

            //Addidng to the list
            contact.Add(contactBook);
        }

        public void View()                                              //this is  the method to view all the contacts stored currently
        {
            if (contact.Count == 0)                                       // this if statement shows that there is nothing in the list
            {
                Console.WriteLine("Currently there are no people added in your addressbook.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Details in contact)                  //this foreacch loops iterates through all the contacts objects in the contacts class
                {
                    //this returns the variables that we have stored 
                    Console.WriteLine("First Name -" + Details.firstName);
                    Console.WriteLine("Last Name -" + Details.lastName);
                    Console.WriteLine("Address -" + Details.address);
                    Console.WriteLine("Phone Number - " + Details.phoneNumber);
                    Console.WriteLine("Email ID -" + Details.email);
                    Console.WriteLine("City -" + Details.city);
                    Console.WriteLine("State -" + Details.state);
                    Console.WriteLine("ZIP code -" + Details.zip);
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }

        }

        public void Edit()                          //this method lets the user edit the details based on their firstname
        {
            Console.WriteLine("Enter the first name of the contact you want to Modify.");
            Console.WriteLine();
            string fname = Console.ReadLine();      // taking the input of first name
            foreach (var Details in contact)
            {
                if (fname == Details.firstName)         //checking the equality of the first name
                {
                    // below codes are similar to that of adding a contact.
                    Console.Write("Enter First Name - ");
                    Details.firstName = Console.ReadLine();
                    Console.Write("Enter Last Name - ");
                    Details.lastName = Console.ReadLine();
                    Console.Write("Enter Address - ");
                    Details.address = Console.ReadLine();
                    Console.Write("Enter Phone number - ");
                    Details.phoneNumber = Console.ReadLine();
                    Console.Write("Enter Email ID - ");
                    Details.email = Console.ReadLine();
                    Console.Write("Enter City - ");
                    Details.city = Console.ReadLine();
                    Console.Write("Enter State - ");
                    Details.state = Console.ReadLine();
                    Console.Write("Enter ZIP code - ");
                    Details.zip = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("No such entry found. Please check and try again!");
                    break;
                }
            }


        }

        //below method is for deleting the contact in the address book based on the search result of the firstname
        public void Delete()
        {
            Console.WriteLine("Enter the first name of the contact you want to Remove.");
            Console.WriteLine();
            string fname = Console.ReadLine();      // taking the input of first name
            foreach (var Details in contact)
            {
                if (fname == Details.firstName)
                {
                    Console.WriteLine("Are you sure you want to delete this Contact? (y/n).");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        contact.Remove(Details);
                        Console.WriteLine("\nContact is Deleted.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact is not present.Please enter correct contact firstname.");
                }
            }

        }

        //this method takes the list and contactbook object of contacts class
        // create method call the list in Contact class using contact object 
        public static Contacts DuplicateEntry(List<Contacts> contactobj, String name)  //here find out search person
        {

            //using contact obj of Contactact class 

            //using lambda expression and equals method
            // create  a person veriable is assign to contact obj
            // p is a veriable contact.find method
            // equals method matching the firstname in contact book
            //using Lamda function
            var Details = contactobj.Find(p => p.firstName.Equals(name));
            //if var person is not null then goto these case
            if (Details != null)
            {
                Console.WriteLine("Already this contact exist with same first name : " + Details.firstName);
                return Details;
            }
            else
            {
                Console.WriteLine("please continue");
                return Details;
            }
            //}
        }

        public static Contacts SearchName(List<Contacts> contactobj, String name)  //here find out search Name
        {
            //using lambda expression and equals method
            // create  a person veriable is assign to contact obj
            // p is a veriable contact.find method
            // equals method matching the firstname in contact book
            //using Lamda function
            var person = contactobj.Find(p => p.firstName.Equals(name));

            if (person != null)
            {
                Console.WriteLine("\n Present :", person.firstName);
                return person;
            }
            else
            {
                Console.WriteLine("\n Not Present.");
                return person;
            }
        }
        public void SearchCity()
        {

            Console.WriteLine("Please enter the city");
            string searchCity = Console.ReadLine();
            //foreach loop to print name of address book and pass address book value to contact person information class

            foreach (KeyValuePair<string, List<Contacts>> keyValuePair in addressBook)
            {
                foreach (KeyValuePair<string, List<Contacts>> tempPair in addressBook)
                {
                    Console.WriteLine(tempPair.Value);
                }
            }
        }
        public void SearchState()
        {
            //used to find custom exception, if state do not exist

            Console.WriteLine("Please enter the state");
            string searchState = Console.ReadLine();
            //foreach loop is used to print key for dictionary and pass the values of dictionary to contact person information class
            foreach (KeyValuePair<string, List<Contacts>> keyValuePair in addressBook)
            {
                foreach (KeyValuePair<string, List<Contacts>> tempPair in addressBook)
                {
                    Console.WriteLine(tempPair.Value);
                }
            }
        }


        public void AddByCity()
        {
            foreach (var Detail in contact)
            {
                string city = Detail.city;
                //containskey means we check for the existance of a perticular element in the dictionary list
                if (cityBook.ContainsKey(city))
                {
                    List<Contacts> exist = cityBook[city];
                    exist.Add(Detail);
                }
                else
                {
                    List<Contacts> cityContact = new List<Contacts>();
                    cityContact.Add(Detail);
                    cityBook.Add(city, cityContact);
                }
            }
        }
        //This method for add person details by using  state name
        public void AddByState()
        {
            foreach (var Detail in contact)
            {
                string state = Detail.state;
                if (stateBook.ContainsKey(state))
                {
                    List<Contacts> exists = stateBook[state];
                    exists.Add(Detail);

                }
                else
                {
                    List<Contacts> stateContact = new List<Contacts>();
                    stateContact.Add(Detail);
                    stateBook.Add(state, stateContact);
                }
            }
        }
        public void ViewByCityName()
        {
            int cityCount = cityBook.Count();
            if (cityCount != 0)
            {
                foreach (KeyValuePair<string, List<Contacts>> item in cityBook)
                {
                    Console.WriteLine("\n Following are the Person details residing in the city -" + item.Key);
                    foreach (var items in item.Value)
                    {
                        //Printing added details
                        Console.WriteLine("First Name : " + items.firstName);
                        Console.WriteLine("Last Name : " + items.lastName);
                        Console.WriteLine("Address : " + items.address);
                        Console.WriteLine("Phone Number : " + items.phoneNumber);
                        Console.WriteLine("Email ID : " + items.email);
                        Console.WriteLine("City : " + items.city);
                        Console.WriteLine("State : " + items.state);
                        Console.WriteLine("ZIP code : " + items.zip);
                    }

                }
            }
            else
            {
                Console.WriteLine("\nCurrently no entries are inserted.");
            }
        }

        public void CountByCity()
        {
            foreach (var item in cityBook)
            {
                int count = item.Value.Count();
                Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
            }
        }

        public void ViewByStateName()
        {
            int stateCount = stateBook.Count();
            if (stateCount != 0)
            {
                foreach (KeyValuePair<string, List<Contacts>> item in stateBook)
                {
                    Console.WriteLine("\n Following are the Person details residing in the state -" + item.Key);
                    foreach (var items in item.Value)
                    {
                        //Printing added details
                        Console.WriteLine("First Name : " + items.firstName);
                        Console.WriteLine("Last Name : " + items.lastName);
                        Console.WriteLine("Address : " + items.address);
                        Console.WriteLine("Phone Number : " + items.phoneNumber);
                        Console.WriteLine("Email ID : " + items.email);
                        Console.WriteLine("City : " + items.city);
                        Console.WriteLine("State : " + items.state);
                        Console.WriteLine("ZIP code : " + items.zip);
                    }

                }
            }
            else
            {
                Console.WriteLine("\nCurrently no entries are inserted.");
            }

        }

        public void CountBystate()
        {
            foreach (var item in stateBook)
            {
                int count = item.Value.Count();
                Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
            }
        }
        /// Sorts the by the first name in alphabetical operator 
        public void SortByFirstName(List<Contacts> contacts)
        {
            contact = contacts.OrderBy(p => p.firstName).ToList();        //lamda fucntion is used
        }
        //sort by entry by choosing the factor
        public void SortBy(List<Contacts> contacts)
        {
            Console.WriteLine("Select the option to Sort the contacts list. 1-City, 2- State, 3- Zip");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                contact = contacts.OrderBy(p => p.city).ToList();
            }
            else if (num == 2)
            {
                contact = contacts.OrderBy(p => p.state).ToList();
            }
            else if (num == 3)
            {
                contact = contacts.OrderBy(p => p.zip).ToList();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please selecct between 1,2 and 3");
            }
        }
        public static void WriteAddressBookUsingStreamWriter()
        {
            //provide file path
            string path = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\AddressBookWriteFile.txt";
            using (StreamWriter se = File.AppendText(path))
            {
                //iterating each element from addressbook dictionary
                foreach (KeyValuePair<string, List<Contacts>> item in addressBook)
                {
                    foreach (var items in item.Value)
                    {
                        //writing in .txt file
                        se.WriteLine("First Name -" + items.firstName);
                        se.WriteLine("Last Name -" + items.lastName);
                        se.WriteLine("Address -" + items.address);
                        se.WriteLine("Phone Number - " + items.phoneNumber);
                        se.WriteLine("Email ID -" + items.email);
                        se.WriteLine("City -" + items.city);
                        se.WriteLine("State -" + items.state);
                        se.WriteLine("ZIP code -" + items.zip);
                    }
                    se.WriteLine("--------------------------------------------------------------");
                }
                se.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
        //This method for readingg address book with person contact from .txt file using File IO
        public static void ReadAddressBookUsingStreamReader()
        {
            Console.WriteLine("The contact List using StreamReader method ");

            string path = @"C:\Users\Vishal\source\repos\Uc15_AddressBook_JSONFileOpration\Uc15_AddressBook_JSONFileOpration\File\AddressBookWriteFile.txt";
            using (StreamReader se = File.OpenText(path))
            {
                string s = " ";
                while ((s = se.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }
    }
}
