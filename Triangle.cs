using System;
using System.Collections.Generic;
using System.Text;

namespace Week_8_Assignment
{
    class Triangle : Shapes
    {
        public int SideA;
        public int SideB;
        public int SideC;

        public void TriangleSides()
        {
            Console.WriteLine("Input Side A.");
            int SideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Side B");
            int SideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Side C.");
            int SideC = int.Parse(Console.ReadLine());

            Console.WriteLine($"Printed List: {ShapeType} | {Color}| {SideA} |{SideB} | {SideC}");
        }
    }
}
