﻿using System;
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
            Console.WriteLine($"Printed List: {ShapeType} | {Color}| {Length} |{Width}");
        }
    }
}
