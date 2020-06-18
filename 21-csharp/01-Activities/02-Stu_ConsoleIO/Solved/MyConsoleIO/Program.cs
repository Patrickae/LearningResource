using System;

namespace MyConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for student"s identification information...
            Console.Write("Please enter the student's first name. ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter the student's middle name. ");
            string middleName = Console.ReadLine();

            Console.Write("Please enter the student's last name. ");
            string lastName = Console.ReadLine();

            // Prompt user for student"s contact information...
            Console.Write("Please enter the student's address. ");
            string address = Console.ReadLine();

            Console.Write("Please enter the student's email. ");
            string email = Console.ReadLine();

            Console.Write("Please enter the student's phone number. ");
            string phoneNumber = Console.ReadLine();

            // Print everything to the console...
            Console.WriteLine("The student's first name is " + firstName);
            Console.WriteLine("The student's last name is " + lastName);
            Console.WriteLine("The student's middle name is " + middleName);

            Console.WriteLine("The student's address is " + address);
            Console.WriteLine("The student's email is " + email);
            Console.WriteLine("The student's phoneNumber is " + phoneNumber);

            Console.Write("Is this information correct? (Y/n) ");
            string confirmation = Console.ReadLine();
        }
    }
}
