using System;
using System.Collections.Generic;
using System.Text;

namespace Week_8_Assignment
{
    public class Rectangle : Shapes
    {
        public int Length;
        public int Width;

        public void RectangleDimension()
        {
            Console.WriteLine("Input Length.");
            int Length = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Width");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine($"Printed List: {ShapeType} | {Color}| {Length} |{Width}");
        }
    }
}
