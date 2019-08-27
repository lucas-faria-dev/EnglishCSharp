using System;

namespace Part002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string vUserFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string vUserLastName = Console.ReadLine();
            
            Console.WriteLine("Hello, {0} {1}", vUserFirstName,vUserLastName);
            //Console.WriteLine("Welcome, "+vUser);
        }
    }
}
