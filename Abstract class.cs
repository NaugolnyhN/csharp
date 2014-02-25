using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4,2);  //new object of the class Rectangle
            Console.WriteLine("Square of the rectangle with the sides 2 and 4 is " + rectangle.CalculateSquare());
            Console.ReadLine();
        }
        abstract class Shape
        {
            public abstract int CalculateSquare();       //abstract method     
        }

        class Rectangle : Shape
        {
           public Rectangle(int length , int width)
            {
                this.length = length;
                this.width = width;
            }
            int length;
            int width;
            public override int CalculateSquare()       //overriding method to non-abstract inheritted class
            {
                int square = length * width;
                return square;
            }
        }
    }
}