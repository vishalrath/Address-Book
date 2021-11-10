using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_uc3
{
    class edit
    {
        public string firstName = "vishal";
        public string lastName = "Rathod";
        public string address = "Washim";
        public string city = "Pune";
        public string state = "Maharstra";
        public string mobNo = "7038762577";

        List<String> obj = new List<String>(); //define List data structure

        public void editdetails(string firstName)  //matching element edited in list data structure
        {
            Console.WriteLine("\nEditing the existing name: ");
            if (this.firstName == firstName)
            {
                Console.WriteLine("\n Enter new name: ");
                obj.Add(Console.ReadLine());   //edit name element
                Console.WriteLine("\n Edited Name Sucessfully..");
            }
            else
            {
                Console.WriteLine("\n Don't edited to existing data..");
            }
        }
    }
}
