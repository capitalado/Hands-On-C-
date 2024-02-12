using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20  
{
    //Class Rectangle
    public class Rectangle
    {
        public int width, length;
        public Rectangle()
        {
            Console.WriteLine("This is a default constructor!");
        }

        public Rectangle(int x, int y)
        {
            Console.WriteLine("This is a Parameterized constructor!");
            width = x;
            length = y;     
        }
        public void area() 
        {
            int area = width * length;
            Console.WriteLine("The Area is: " + area);
        }

    }

    //Main Program starts here
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(3, 4);
            r2.area();

           Console.ReadKey();
        }
    }
}
