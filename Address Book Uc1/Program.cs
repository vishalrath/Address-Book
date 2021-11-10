using System;

namespace Address_Book_Uc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my address book program");
            Console.WriteLine("Please Enter your Firstname");
            string str2 = "Firstname";
            str2 = Console.ReadLine();
            string valueString2 = str2;

            Console.WriteLine("Please Enter your Lastname");
            string str1 = "Firstname";
            str1 = Console.ReadLine();
            string valueString1 = str1;

            Console.WriteLine("Please Enter your mobile number");
            string mobileno = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter your Address");
            string Address = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Please Enter your City");
            string str5 = "City";
            str5 = Console.ReadLine();
            string valueString5 = str5;

            Console.WriteLine("Please Enter your Postcode");
            string str6 = "Postcode";
            str6 = Console.ReadLine();
            string valueString6 = str6;

            Console.WriteLine("Please Enter your State");
            string str7 = "State";
            str6 = Console.ReadLine();
            string valueString7 = str7;
            Console.WriteLine("Please Enter your Email");
            string str8 = "Email";
            str6 = Console.ReadLine();
            string valueString8 = str8;


        }
    }
}
