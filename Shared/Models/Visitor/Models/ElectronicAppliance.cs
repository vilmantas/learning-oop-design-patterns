using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor.Models
{
    public class ElectronicAppliance : Product
    {
        public string EnergyEfficiency { get; set; }
        public string Brand { get; set; }

        public override void Apply(Visitor visitor)
        {
            visitor.VisitElectronicAppliance(this);
        }
    }
}
