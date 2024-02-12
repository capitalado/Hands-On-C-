using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem, sum = 0, temp;
            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + (rem*rem*rem);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong number");
            }
            Console.ReadKey();
        }
    }
}
