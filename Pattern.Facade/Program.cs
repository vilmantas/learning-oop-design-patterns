using System;
using System.Collections.Generic;
using Shared.Models.Facade;
using Shared.Models.Facade.Domain.Shapes;
using Shared.Models.Facade.Domain.Shapes.Abstract;

namespace Pattern.Facade
{
    class Program
    {
        static void Main()
        {
            List<IShape> shapes = new List<IShape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Square());

            double area = AreaCalculatorFacade.CalculateArea(shapes);

            Console.WriteLine(area);

            Console.Read();
        }
    }
}
