using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Height:");
            int height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Rectangle rect = new Rectangle(width, height);

            Console.WriteLine("Area is:" + rect.getArea());
            Console.WriteLine("Perimeter is:" + rect.getPerimeter());


            Console.WriteLine("Enter Side Length:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Square sq = new Square(length);

            Console.WriteLine("Area is:" + sq.getArea());
            Console.WriteLine("Perimeter is:" + sq.getPerimeter());

            List<Rectangle> listOfRectangles = new List<Rectangle>();
            listOfRectangles.Add(rect);
            listOfRectangles.Add(sq);

            foreach (Rectangle r in listOfRectangles)
            {
                Console.WriteLine(r.ToString());
            }


            Console.ReadLine();


        }
    }
}
