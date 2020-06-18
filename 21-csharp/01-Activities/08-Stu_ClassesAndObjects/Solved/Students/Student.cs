using System;

namespace Students
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }

        private static int created = 0;

        public Student()
        {
            Student.created += 1;
        }

        public void printAttributes()
        {
            Console.WriteLine("This student's first name is " + this.firstName + ".");
            Console.WriteLine("This student's last name is " + this.lastName + ".");
            Console.WriteLine("This student's middle name is " + this.middleName + ".");

            Console.WriteLine("This student's email is " + this.email + ".");
            Console.WriteLine("This student's address is " + this.address + ".");
            Console.WriteLine("This student's phoneNumber is " + this.phoneNumber + ".");
        }

        public int getCreated() {
            return Student.created;
        }
    }

}
