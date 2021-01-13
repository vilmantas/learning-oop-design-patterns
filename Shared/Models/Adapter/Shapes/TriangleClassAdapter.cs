using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Adapter.Shapes.Abstract;
using Shared.Models.Adapter.Shapes.External;

namespace Shared.Models.Adapter.Shapes
{
    public class TriangleClassAdapter : TriangleWidget, IShape
    {
        public double GetArea()
        {
            return base.SomeExternalAreaCalculationOperation();
        }
    }
}
