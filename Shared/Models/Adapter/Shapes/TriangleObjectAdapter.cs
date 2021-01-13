using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Adapter.Shapes.Abstract;
using Shared.Models.Adapter.Shapes.External;

namespace Shared.Models.Adapter.Shapes
{
    public class TriangleObjectAdapter : IShape
    {
        private readonly TriangleWidget _triangleWidget;

        public TriangleObjectAdapter(TriangleWidget triangleWidget)
        {
            _triangleWidget = triangleWidget;
        }

        public double GetArea()
        {
            return _triangleWidget.SomeExternalAreaCalculationOperation();
        }
    }
}
