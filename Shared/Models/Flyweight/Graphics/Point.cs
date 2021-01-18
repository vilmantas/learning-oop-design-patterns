using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Flyweight.Graphics
{
    public class Point
    {
        public readonly Color Color;

        public Point(Color color)
        {
            Color = color;
        }
    }
}
