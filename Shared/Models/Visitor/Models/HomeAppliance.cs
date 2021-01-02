using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor.Models
{
    public class HomeAppliance : Product
    {
        public string Brand { get; set; }

        public DateTime ProductionDate { get; set; }

        public override void Apply(Visitor visitor)
        {
            visitor.VisitHomeAppliance(this);
        }
    }
}
