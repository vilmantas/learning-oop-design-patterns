using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Flyweight.Graphics
{
    public class Line
    {
        static readonly PointFactory factory = new PointFactory();
        
        public Color LineColor { get; set; } = Color.Empty;

        public List<(int x, int y)> Points { get; set; } = new List<(int x, int y)>();

        public void AddPoint(int x, int y)
        {
            Points.Add((x, y));
        }

        public void DrawLine(Graphic g)
        {
            var point = factory.CreatePoint(this.LineColor);

            foreach((int x, int y) valueTuple in Points)
            {
                Console.WriteLine("Drawing point...");
                g.DrawPoint(point, valueTuple.x, valueTuple.y);
            }
        }
    }
}
