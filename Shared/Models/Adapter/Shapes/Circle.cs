using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Adapter.Shapes.Abstract;

namespace Shared.Models.Adapter.Shapes
{
    public class Circle : IShape
    {
        public double GetArea()
        {
            return 0f;
        }
    }
}
