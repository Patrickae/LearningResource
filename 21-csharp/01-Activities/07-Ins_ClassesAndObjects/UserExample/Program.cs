using System;

namespace UserExample
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr1 = new User("Jim", "Doe", "jim@doe.com");
            // Console.WriteLine(usr1.email); // can't access!
            Console.WriteLine(usr1.getFirstName());

            User usr2 = new User("Mauricio", "Smith", "mauricio@doe.com");
            Console.WriteLine(usr2.getFirstName());

            Console.WriteLine(User.getCreated() + " users have been created.");
        }
    }
}
