using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_DuplicateEntry_AddressBook
{
    class AddressBook
    {
        //declaring a list with the class Contacts as the type
        //declaring adictionary with the already declared list inside of it as the value pair
        public static List<Contacts> contact = new List<Contacts>();
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
        //this method takes the list and contactbook object of contacts class
        // create method call the list in Contact class using contact object and call the contactbbok to contact class
        public static void SearchDuplicate(List<Contacts> contactsobj, Contacts contactBook)
        {
            //iteratingall elements in contact list by using for each loop
            //using contact obj of Contactact class 

            foreach (var Details in contactsobj)
            {
                //using lambda expression and equals method
                // create  ap erson veriable is assign to contact obj
                // p is a veriable contact.find method
                // equals method matching the firstname in contact book
                //using Lamda function
                var person = contactsobj.Find(p => p.firstName.Equals(contactBook.firstName));
                //if var person is not null then goto these case
                if (person != null)
                {
                    Console.WriteLine("Already this contact exist with same first name : " + person.firstName);
                   // return 1;
                }
                else
                {
                    Console.WriteLine("please continue");
                   // return 0;
                }
            }
           
        }
    }
}
