using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Uc5
{
    class Add
    {
        public string firstName = "vishal";
        public string lastName = "Rathod";
        public string address = "Washim";
        public string city = "Pune";
        public string state = "Maharstra";
        public string mobNo = "7038762577";

        List<String> obj = new List<String>(); //define List data structure

        public void adddetails()  // element adding..
        {
            //new adding element in List datastructure...
            Console.WriteLine("\n Enter the Number of Person:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter the Details.");
            //Adding for multiple person on list data structure
            for (int i = 1; i <= num; i++) 
            {
               
                if (this.firstName == firstName)
                {
                    
                    Console.WriteLine("\nFirst Name:");
                    string firstName = Convert.ToString(Console.ReadLine());
                    obj.Add(firstName);
                    Console.WriteLine("\nLast Name:");
                    string lastName = Convert.ToString(Console.ReadLine());
                    obj.Add(lastName);
                    Console.WriteLine("\nAddress is:");
                    string address = Convert.ToString(Console.ReadLine());
                    obj.Add(address);
                    Console.WriteLine("\nCity :");
                    string city = Convert.ToString(Console.ReadLine());
                    obj.Add(city);
                    Console.WriteLine("\nState :");
                    string state = Convert.ToString(Console.ReadLine());
                    obj.Add(state);
                    Console.WriteLine("\nMobile No :");
                    string mobNo = Convert.ToString(Console.ReadLine());
                    obj.Add(mobNo);

                    Console.WriteLine("\n New Data is Added..");

                }
                else
                {
                    Console.WriteLine("\n Already Data Exists..");
                }
            }
        }
    }
}







