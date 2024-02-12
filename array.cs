using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fixer;
            int[] myArr = new int[5];
            Console.WriteLine("Enter 5 elements: ");
            for (i = 0; i < 5; i++)
            {
                myArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            fixer = myArr.Min();
            Console.WriteLine("The Minimum number is: " + fixer);
            Console.ReadKey();
        }
    }
}
