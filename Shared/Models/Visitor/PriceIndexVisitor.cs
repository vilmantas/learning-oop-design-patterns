using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Visitor.Models;

namespace Shared.Models.Visitor
{
    public class PriceIndexVisitor : Visitor
    {
        public float PriceIndex { get; set; }

        public override void VisitElectronicAppliance(ElectronicAppliance electronicAppliance)
        {
            ResetState();

            if (electronicAppliance.Brand == "Sony" || electronicAppliance.Brand == "Toshiba")
            {
                PriceIndex += 30;
            }
            if (electronicAppliance.EnergyEfficiency == "A+")
            {
                PriceIndex += 50;
            }
            else if (electronicAppliance.EnergyEfficiency == "A")
            {
                PriceIndex += 40;
            }
            else if (electronicAppliance.EnergyEfficiency == "B")
            {
                PriceIndex += 20;
            }
            else if (electronicAppliance.EnergyEfficiency == "C")
            {
                PriceIndex += 5;
            }
        }

        public override void VisitGrocery(Grocery grocery)
        {
            ResetState();

            if (grocery.IsUpmarket)
            {
                PriceIndex += 50;
            }
        }

        public override void VisitHomeAppliance(HomeAppliance homeAppliance)
        {
            ResetState();

            if (homeAppliance.ProductionDate.Year >= 2015)
            {
                PriceIndex += 80;
            }
        }

        public override void VisitVehicle(Vehicle vehicle)
        {
            ResetState();

            if (vehicle.IsLimitedEdition)
            {
                PriceIndex += 20;
            }
            if (vehicle.IsSecondhand == false)
            {
                PriceIndex += 30;
            }
            if (vehicle.ProductionDate.Year >= 2018)
            {
                PriceIndex += 30;
            }

            if (vehicle.ProductionDate.Year >= 2018 && vehicle.IsSecondhand == false)
            {
                PriceIndex += 50;
            }

            if (vehicle.IsLimitedEdition && vehicle.ProductionDate.Year <= 1990)
            {
                PriceIndex += 50;
            }
        }

        private void ResetState()
        {
            PriceIndex = 0;
        }
    }
}
