using System;
using System.Collections.Generic;

namespace MyConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /* Next, create a dict, whose keys are the same as the variable names you've
                 * been using. Set their value equal to "None", which is Python's version of
                 * JavaScript's null. Refactor your calls to input such that they assign to
                 * the dictionary's values directly, rather than to variable names. It'll
                 * look very similar! */
                Dictionary<string, string> student = new Dictionary<string, string>();

                // Prompt user for student"s identification information, and
                //   save it into the dictionary.
                Console.Write("Please enter the student's first name. ");
                string firstName = Console.ReadLine();
                student.Add("first name", firstName);

                Console.Write("Please enter the student's middle name. ");
                string middleName = Console.ReadLine();
                student.Add("middle name", middleName);

                Console.Write("Please enter the student's last name. ");
                string lastName = Console.ReadLine();
                student.Add("last name", lastName);

                // Prompt user for student"s contact information...
                Console.Write("Please enter the student's address. ");
                string address = Console.ReadLine();
                student.Add("address", address);

                Console.Write("Please enter the student's email. ");
                string email = Console.ReadLine();
                student.Add("email", email);

                Console.Write("Please enter the student's phone number. ");
                string phoneNumber = Console.ReadLine();
                student.Add("phone number", phoneNumber);

                // Print everything to the console...
                foreach (KeyValuePair<string, string> pair in student)
                {
                    Console.WriteLine("The student's " + pair.Key + " is " + pair.Value + ".");
                }

                /* Use a conditional statement here. If they say "No", simply continue the loop,
                 * so they can enter the information again.
                 *
                 * If they say "Yes", add the student to a list, and prompt them again, asking
                 * if they want to add another student.
                 *
                 * If they say "Yes" again, continue the loop. If not, print every student in
                 * your list.
                 *
                 * Take this one step by step, and don't get overwhelmed. It's okay if this
                 * is challenging! */

                Console.Write("Is this information correct? (Y/n) ");
                string confirmation = Console.ReadLine();
                if (confirmation == "y" || confirmation == "Y")
                {
                    break;
                }
            }
        }
    }
}
