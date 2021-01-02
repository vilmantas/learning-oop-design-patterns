using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor.Models
{
    public class Vehicle : Product
    {
        public bool IsSecondhand { get; set; }
        public DateTime ProductionDate { get; set; }
        public bool IsLimitedEdition { get; set; }
        public float EngineSize { get; set; }

        public override void Apply(Visitor visitor)
        {
            visitor.VisitVehicle(this);
        }
    }
}
