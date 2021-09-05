using System;
using System.Collections.Generic;
using System.Text;

namespace Week_8_Assignment
{
    public class Shapes
    {
        public string Color;
        public string ShapeType;
        public int ShapeArea;
        public void QuiltCollection()
        {
            Console.WriteLine($"Printed List: {ShapeType} | {Color} | {ShapeArea}cm.");
        }
    }
}
