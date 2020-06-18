using System;
using System.Collections.Generic;

namespace FunctionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> students = new List<Dictionary<string, string>>();

            while (true)
            {
                Dictionary<string, string> student = new Dictionary<string, string>();

                // An example of a good use case for arrays over array lists.
                string[] attributes = new string[] { "first name", "last name", "middle name",
                                                     "address", "email", "phone number" };

                foreach (string attribute in attributes)
                {
                    Helpers.saveAttribute(attribute, student);
                }

                Helpers.printEntries(student);

                if (Helpers.confirm()) {
                    break;
                }
            }
        }
    }
}
