using System;

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

            Rectangle r = new Rectangle(width, height);

            Console.WriteLine("Area is:" + r.getArea());
            Console.WriteLine("Perimeter is:" + r.getPerimeter());


            Console.WriteLine("Enter Side Length:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Square s = new Square(length);

            Console.WriteLine("Area is:" + s.getArea());
            Console.WriteLine("Perimeter is:" + s.getPerimeter());



            Console.ReadLine();


        }
    }
}
