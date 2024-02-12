using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, original, rem, sum = 0;
            Console.Write("Enter a number to check: ");
            num = Convert.ToInt32(Console.ReadLine());
            original = num;
            while(num != 0){
                rem = num % 10;
                sum = (sum*10) + rem;
                num = num / 10;
            }

            if (original == sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
