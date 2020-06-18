using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Student student = new Student();

                // Or, if fiels are private, something like:
                //   student.setFirstName(promptForAttribute("first name"));
                student.firstName = Helpers.promptForAttribute("first name");
                student.lastName = Helpers.promptForAttribute("last name");
                student.middleName = Helpers.promptForAttribute("middle name");

                student.email = Helpers.promptForAttribute("email");
                student.address = Helpers.promptForAttribute("address");
                student.phoneNumber = Helpers.promptForAttribute("phone number");

                student.printAttributes();
                Console.WriteLine("This is student Number " + student.getCreated() + ".");

                if (Helpers.confirm())
                {
                    break;
                }
            }
        }
    }
}
