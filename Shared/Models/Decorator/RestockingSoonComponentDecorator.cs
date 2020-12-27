using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Decorator
{
    public class RestockingSoonComponentDecorator : Decorator
    {
        public RestockingSoonComponentDecorator(IComponent component) : base(component)
        {
        }

        public override string Name => $"{base.Name} -- RESTOCKING SOON --";
    }
}
