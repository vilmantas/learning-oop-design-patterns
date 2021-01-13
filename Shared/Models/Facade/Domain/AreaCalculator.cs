using System.Collections.Generic;
using System.Linq;
using Shared.Models.Facade.Domain.Shapes.Abstract;

namespace Shared.Models.Facade.Domain
{
    public class AreaCalculator
    {
        public static CalculationResult CalculateArea(IEnumerable<IShape> shapes) => new CalculationResult(shapes.Sum(x => x.GetArea()));
    }
}
