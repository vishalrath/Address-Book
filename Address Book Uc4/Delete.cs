using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Uc4
{
    class Delete
    {
        public string firstName = "vishal";
        public string lastName = "rathod";
        public string address = "washim";
        public string city = "Pune";
        public string state = "Maharstra";
        public string mobNo = "7038762577";

        List<String> obj = new List<String>(); //define List data structure

        public void remove(string firstName)  //matching element deleted in list data structure
        {
            if (this.firstName == firstName)
            {
                obj.Remove(firstName); //remove name element
                Console.WriteLine("\n Name Successfully deleted...");
            }
            else
            {
                Console.WriteLine("\n Not deleted...");
            }
        }
    }
}
