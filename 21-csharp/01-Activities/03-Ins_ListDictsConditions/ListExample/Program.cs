using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<$TYPE> $NAME = new List<$TYPE>();
            List<string> names = new List<string>();

            names.Add("John");
            names.Add("Jacob");
            names.Add("Jingleheimer");
            names.Add("Smith");

            // Iterating is easy.
            foreach (string name in names)
            {
                Console.WriteLine("The current name is " + name + ".");
            }
        }
    }
}
