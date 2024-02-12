using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, k, i, count;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("The Prime numbers between {0} and {1} are: \n", num1, num2);
            for (k = num1; k <= num2; k++)
            {
                count = 0;
                for (i = 2; i <= k / 2; i++)
                {
                    if (k % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && k != 1)
                {
                    Console.Write("{0} ", k);
                }
            }
            Console.ReadKey();
        }
    }
}
