using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models.Facade.Domain;
using Shared.Models.Facade.Domain.Shapes.Abstract;

namespace Shared.Models.Facade
{
    public static class AreaCalculatorFacade
    {
        public static double CalculateArea(IEnumerable<IShape> shapes) => AreaCalculator.CalculateArea(shapes).Result;
    }
}
