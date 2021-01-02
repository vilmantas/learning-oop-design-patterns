using Shared.Models.Visitor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitGrocery(Grocery grocery);
        public abstract void VisitElectronicAppliance(ElectronicAppliance electronicAppliance);
        public abstract void VisitHomeAppliance(HomeAppliance homeAppliance);
        public abstract void VisitVehicle(Vehicle vehicle);
    }
}
