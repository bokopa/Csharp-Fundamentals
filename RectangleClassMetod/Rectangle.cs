using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleClassMetod
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width{ get; set; }
        public int Hight { get; set; }

        public int Bottom { get { return Top + Hight; }}
        public int Right { get { return Left + Width; } }

        public int CalculateArea ()
        {
            return Width * Hight;
        }
        public bool IsInside(Rectangle other)
        {
            return Left >= other.Left;

        }
    }
}
