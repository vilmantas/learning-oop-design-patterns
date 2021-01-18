using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = Shared.Models.Flyweight.Graphics.Point;

namespace Shared.Models.Flyweight
{
    public class PointFactory
    {
        private Dictionary<string, Point> points { get; set; } = new Dictionary<string, Point>();

        public Point CreatePoint(Color color)
        {
            if(points.TryGetValue(color.Name, out Point factoryPoint))
            {
                Console.WriteLine("Getting point from repository...");
                return factoryPoint;
            }

            Console.WriteLine("Creating new Point...");
            var point = new Point(color);
            points.Add(color.Name, point);
            return point;
        }
    }
}
