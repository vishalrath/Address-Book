using System;
using System.Collections.Generic;

namespace Uc15_AddressBook_JSONFileOpration
{
    class Program
    {
        static void Main(string[] args)
        {

            //Class variable declaration

            List<Contacts> list = new List<Contacts>();
            int num;
            //AddressBook myAdd = new AddressBook();
            //below lines of code is executed at the begining to guide the user to enter their choice
            Console.WriteLine("*****Welcome to the address book program*****");
            Console.WriteLine();
            Console.WriteLine("Enter the number of Address Books you want to add:");
            int numAddBook = Convert.ToInt32(Console.ReadLine());          //taking user inputs about the number of add books needed
            int numberBook = 0;
            Console.WriteLine();
            while (numberBook < numAddBook)                                //this while loop runs till the favourable no. of add books are created
            {
                Console.WriteLine("Enter the name of the address book");
                string book = Console.ReadLine();                         //taking the add book name as input
                Console.WriteLine("Select the option that you would like to perform.");
                Console.WriteLine();
                //declaring address book object to be used in the below cases
                AddressBook Person = new AddressBook();
                string keyPress = "o";

                while (keyPress != "n")
                {
                    Console.WriteLine("1- Add contact, 2- View all contacts, 3- Edit contact, 4- Delete contact,5-SearchName  ,6-SearchCity,7-ViewByCity, 8-CountByCity 9-SearchState, 10-ViewByState,11-CountByState, 12-SortByPersonName,  13-SortByFacter");
                    num = Convert.ToInt32(Console.ReadLine());

                    switch (num)                                            //this switch case selects or enables the user to select multiple cases
                    {
                        case 1:
                            Person.AddAddress();                            //method to add a new contact
                            break;

                            //case 2:
                            //    Person.View();                                  //method invoking to view all the contacts
                            //    break;

                            //case 3:
                            //    Person.Edit();                                  //method to edit the contacts
                            //    break;

                            //case 4:
                            //    Person.Delete();                                  //method to delete the contacts
                            //    break;
                            //case 5:
                            //    AddressBook.SearchName(list, "vishal");
                            //    break;
                            //case 6:
                            //    Person.SearchCity();
                            //    break;

                            //case 7:
                            //    Person.ViewByCityName();
                            //    break;
                            //case 18:
                            //    Person.CountByCity();
                            //    break;
                            //case 9:
                            //    Person.SearchState();
                            //    break;
                            //case 10:
                            //    Person.ViewByStateName();
                            //    break;
                            //case 11:
                            //    Person.CountBystate();
                            //    break;
                            //case 12:
                            //    Person.SortByFirstName(AddressBook.contact);
                            //    break;
                            //case 13:
                            //    Person.SortBy(AddressBook.contact);
                            //    break;

                    }
                    Console.WriteLine("Do you wish to continue?----- Press (y/n)");
                    keyPress = Console.ReadLine();
                }
                AddressBook.AddTo(book);    //calling the AddTo method to add the new address book in the dictionary
                                            //incrementing the variable
                     AddressBook.WriteAddressBookUsingStreamWriter();
                 AddressBook.ReadAddressBookUsingStreamReader();
               // AddressBookUsingCvsFile.CsvSerialise(AddressBook.contact);
               // AddressBookUsingCvsFile.CsvDeSerialise();
                 AddressBookUsingJson.JsonSerializeAddressBook(AddressBook.contact);
                 AddressBookUsingJson.JsonDeserializeAddressBook();
                //incrementing the variable
                numberBook++;
                Console.ReadLine();
            }
           
        }
    }
    
}
