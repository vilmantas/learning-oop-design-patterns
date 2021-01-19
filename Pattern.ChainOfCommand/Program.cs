using System;
using System.Collections.Generic;
using Shared.Models;
using Shared.Models.ChainOfCommand;

namespace Pattern.ChainOfCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<InformationProduct>();

            components.Add(new Product(null, "TV", 299.99f, "STAND ALONE PRODUCT"));
            components.Add(new Product(null, "Radio", 19.99f, "STAND ALONE PRODUCT"));

            var razerRig = new ProductPackage(null, "Razer Gaming PC Components", 99.99f, "GREAT PC RIG WITH MOUSE KEYBOARD AND HEADSET");
            razerRig.AddComponent(new Product(razerRig, "Razer Gaming Mouse", 29.99f));
            razerRig.AddComponent(new Product(razerRig, "Razer Gaming Keyboard", 19.99f));
            razerRig.AddComponent(new Product(razerRig, "Razer Gaming Headset", 199.99f));

            var razerPc = new ProductPackage(razerRig ,"Razer Gaming PC", 19.99f);

            var razerLeds = new Product(razerPc, "Razer PC Leds", 29.99f, "RAZER LEDS");

            var razerCase = new Product(razerPc, "Razer PC Case", 59.99f);

            razerPc.AddComponent(razerCase);
            razerPc.AddComponent(razerLeds);
            razerPc.AddComponent(new Product(razerPc, "Razer PC Fan", 19.99f));
            razerPc.AddComponent(new Product(razerPc, "Razer RGB Ram", 89.99f));

            razerRig.AddComponent(razerPc);

            var razerGamingPackage = new ProductPackage(null, "Razer Gaming Package", 99.99f, "INFORMATION ABOUT GAMING PACKAGE");
            razerGamingPackage.AddComponent(new Product(razerGamingPackage, "Razer Gaming Char", 199.99f));
            razerGamingPackage.AddComponent(new Product(razerGamingPackage, "Razer Gaming 4K Monitor", 199.99f));
            razerGamingPackage.AddComponent(razerRig);

            var utensilsPackage = new ProductPackage(null, "Utensils Package", 2.99f, "UTENSILS PACKAGE");

            var knives = new Product(utensilsPackage, "10 Knives", 9.99f, "KNIVES");

            var spoons = new Product(utensilsPackage, "10 Spoons", 9.99f);

            utensilsPackage.AddComponent(knives);
            utensilsPackage.AddComponent(new Product(utensilsPackage, "10 Forks", 9.99f, "FORKS"));
            utensilsPackage.AddComponent(spoons);

            components.Add(razerGamingPackage);
            components.Add(utensilsPackage);

            // Should print own info
            Console.WriteLine("KNIVES INFO");
            knives.HandleInformationRequest();

            // Should send info request to parent
            Console.WriteLine("SPOONS INFO");
            spoons.HandleInformationRequest();

            // Should print own info
            Console.WriteLine("RIG INFO");
            razerRig.HandleInformationRequest();

            // Should print parent info
            Console.WriteLine("PC INFO");
            razerPc.HandleInformationRequest();

            // Should print parent parent info
            Console.WriteLine("CASE INFO");
            razerCase.HandleInformationRequest();

            Console.ReadLine();
        }
    }
}
