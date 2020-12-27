using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Decorator
{
    public class OutOfStockComponentDecorator : Decorator
    {
        public OutOfStockComponentDecorator(IComponent component) : base(component)
        {
        }

        public override string Name => $"{base.Name} -- OUT OF STOCK -- ";
    }
}
