using System;
using System.Collections.Generic;
using System.Text;

namespace Week_8_Assignment
{
    class Triangle : Shapes
    {
        public int sideA;
        public int sideB;
        public int sideC;

        public void TriangleSides()
        {
            Console.WriteLine($"Printed List: {ShapeType} | {Color}| {sideA} |{sideB} | {sideC}");
        }
    }
}
