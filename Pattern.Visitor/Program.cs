using Shared.Models.Visitor;
using Shared.Models.Visitor.Models;
using System;
using System.Collections.Generic;

namespace Pattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new HomeAppliance
            {
                Name = "Skalbenke 3000",
                Brand = "Mitsubishi",
                Price = 199.99f,
                ProductionDate = DateTime.Now.AddYears(-10),
                Weight = 46f
            });

            products.Add(new HomeAppliance
            {
                Name = "Indaplove 5000",
                Brand = "Porsche",
                Price = 599.99f,
                ProductionDate = DateTime.Now.AddYears(-7),
                Weight = 40f
            });

            products.Add(new Vehicle
            {
                EngineSize = 1.9f,
                IsLimitedEdition = false,
                IsSecondhand = true,
                ProductionDate = DateTime.Now.AddYears(-20),
                Price = 1500,
                Weight = 1800f,
                Name = "Ferrari",
            });

            products.Add(new Grocery
            {
                IsUpmarket = true,
                Name = "Caviar",
                Price = 7500f,
                Weight = 1
            });

            Console.WriteLine();
            Console.WriteLine(" ---- PROBLEMATIC IMPLEMENTATION ---- ");
            Console.WriteLine();


            foreach (Product product in products)
            {
                var priceIndex = 0f;

                if (product is Grocery grocery)
                {
                    if (grocery.IsUpmarket)
                    {
                        priceIndex += 50;
                    }
                } 
                else if (product is Vehicle vehicle)
                {
                    if (vehicle.IsLimitedEdition)
                    {
                        priceIndex += 20;
                    }
                    if (vehicle.IsSecondhand == false)
                    {
                        priceIndex += 30; 
                    }
                    if (vehicle.ProductionDate.Year >= 2018)
                    {
                        priceIndex += 30;
                    }

                    if (vehicle.ProductionDate.Year >= 2018 && vehicle.IsSecondhand == false)
                    {
                        priceIndex += 50;
                    }

                    if (vehicle.IsLimitedEdition && vehicle.ProductionDate.Year <= 1990)
                    {
                        priceIndex += 50;
                    }
                }
                else if (product is HomeAppliance homeAppliance)
                {
                    if (homeAppliance.ProductionDate.Year >= 2015)
                    {
                        priceIndex += 80;
                    }
                } 
                else if (product is ElectronicAppliance electronicAppliance)
                {
                    priceIndex = CalculateElectronicAppliancePriceIndex(priceIndex, electronicAppliance);
                }

                Console.WriteLine($"Product: {product.Name}, Price: {product.Price} - Price index: {priceIndex}");
            }

            Console.WriteLine();
            Console.WriteLine(" ---- VISITOR PATTERN ---- ");
            Console.WriteLine();

            var priceIndexVisitor = new PriceIndexVisitor();

            foreach (Product product in products)
            {
                product.Apply(priceIndexVisitor);

                Console.WriteLine($"Product: {product.Name}, Price: {product.Price} - Price index: {priceIndexVisitor.PriceIndex}");
            }

            Console.ReadLine();
        }

        private static float CalculateElectronicAppliancePriceIndex(float priceIndex, ElectronicAppliance electronicAppliance)
        {
            if (electronicAppliance.Brand == "Sony" || electronicAppliance.Brand == "Toshiba")
            {
                priceIndex += 30;
            }
            if (electronicAppliance.EnergyEfficiency == "A+")
            {
                priceIndex += 50;
            }
            else if (electronicAppliance.EnergyEfficiency == "A")
            {
                priceIndex += 40;
            }
            else if (electronicAppliance.EnergyEfficiency == "B")
            {
                priceIndex += 20;
            }
            else if (electronicAppliance.EnergyEfficiency == "C")
            {
                priceIndex += 5;
            }

            return priceIndex;
        }
    }
}
