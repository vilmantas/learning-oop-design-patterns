using System;
using System.Drawing;
using Shared.Models.Flyweight;
using Shared.Models.Flyweight.Graphics;

namespace Pattern.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphic screen = new Graphic();

            Line firstLine = new Line { LineColor = Color.Red };

            firstLine.AddPoint(0, 0);
            firstLine.AddPoint(0, 1);
            firstLine.AddPoint(0, 2);
            firstLine.AddPoint(0, 3);

            Line secondLine = new Line { LineColor = Color.Black };

            secondLine.AddPoint(0, 0);
            secondLine.AddPoint(1, 0);
            secondLine.AddPoint(2, 0);
            secondLine.AddPoint(3, 0);

            Line thirdLine = new Line { LineColor = Color.Black };

            thirdLine.AddPoint(0, 0);
            thirdLine.AddPoint(1, 1);
            thirdLine.AddPoint(2, 2);
            thirdLine.AddPoint(3, 3);

            Console.WriteLine("Drawing first line...");
            firstLine.DrawLine(screen);

            Console.WriteLine();
            Console.WriteLine("Drawing second line...");
            secondLine.DrawLine(screen);

            Console.WriteLine();
            Console.WriteLine("Drawing third line...");
            thirdLine.DrawLine(screen);



        }
    }
}
