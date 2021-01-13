using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Facade.Domain
{
    public class CalculationResult
    {
        public double Result { get; init; }

        public CalculationResult(double result)
        {
            Result = result;
        }
    }
}
