using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Facade.Domain.Shapes.Abstract;

namespace Shared.Models.Facade.Domain.Shapes
{
    public class Rectangle : IShape
    {
        public double GetArea()
        {
            return 3.2f;
        }
    }
}
