using System;
using System.Collections.Generic;
using Shared.Models.Adapter.Shapes;
using Shared.Models.Adapter.Shapes.Abstract;
using Shared.Models.Adapter.Shapes.External;

namespace Pattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Square());

            shapes.Add(new TriangleClassAdapter()); // Sub-classed adapter
            shapes.Add(new TriangleObjectAdapter(new TriangleWidget())); // Object passed to adapter

            double area = 0f;

            foreach(IShape shape in shapes)
            {
                area += shape.GetArea();
            }

            Console.WriteLine(area);

            Console.Read();
        }
    }
}
