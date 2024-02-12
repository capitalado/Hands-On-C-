using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check: ");
            String name = Console.ReadLine();
            String reverse = String.Empty;

            for (int i = name.Length - 1; i >= 0; i--) { 
            reverse+=name[i];
            }
            if (name == reverse)
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
