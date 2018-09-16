using System;

namespace RectangleClassMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Top = 10;
            rect.Left = 5;
            rect.Width = 20;
            rect.Hight = 30;
            int bottom = rect.Bottom;
            int right = rect.Right;

            rect.CalculateArea();
        }
    }
}
