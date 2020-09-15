using System;
using System.Drawing;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var newSquare = new Square(7);
            var r = new Rectangle();

            Console.WriteLine("the side length of the square is " + newSquare.SideLength);
            Console.WriteLine("The area of the square is: " + newSquare.CalculateArea());
            Console.WriteLine("The perimeter of the square is: " + newSquare.CalculatePerimeter());

            Console.ReadLine(); 
        }

    } 
  
}
