using System;

namespace Week_8_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quilt shape tracker. You will select your shape, input, your, color, and the shape area. ");
            var collection = new Shapes();

            Console.WriteLine("Please select shape color.");
            collection.Color = Console.ReadLine();

            Console.WriteLine("Please input shape: Triangle, Square, Rectangle.");
            collection.ShapeType = Console.ReadLine();

            //Console.WriteLine("Input shape dimension.");
            //collection.ShapeArea = int.Parse(Console.ReadLine());

            collection.QuiltCollection();
         
        }
    }
}
