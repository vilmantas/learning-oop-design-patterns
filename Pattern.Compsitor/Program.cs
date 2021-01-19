using Shared.Helpers;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace Compsitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<IComponent>();

            components.Add(new Product("TV", 299.99f));
            components.Add(new Product("Radio", 19.99f));

            var razerPc = new ProductPackage("Razer Gaming PC", 19.99f);
            razerPc.AddComponent(new Product("Razer PC Case", 59.99f));
            razerPc.AddComponent(new Product("Razer PC Leds", 29.99f));
            razerPc.AddComponent(new Product("Razer PC Fan", 19.99f));
            razerPc.AddComponent(new Product("Razer RGB Ram", 89.99f));

            var razerRig = new ProductPackage("Razer Gaming PC Components", 99.99f);
            razerRig.AddComponent(new Product("Razer Gaming Mouse", 29.99f));
            razerRig.AddComponent(new Product("Razer Gaming Keyboard", 19.99f));
            razerRig.AddComponent(new Product("Razer Gaming Headset", 199.99f));
            razerRig.AddComponent(razerPc);


            var razerGamingPackage = new ProductPackage("Razer Gaming Package", 99.99f);
            razerGamingPackage.AddComponent(new Product("Razer Gaming Char", 199.99f));
            razerGamingPackage.AddComponent(new Product("Razer Gaming 4K Monitor", 199.99f));
            razerGamingPackage.AddComponent(razerRig);

            var utensilsPackage = new ProductPackage("Utensils Package", 2.99f);
            utensilsPackage.AddComponent(new Product("10 Knives", 9.99f));
            utensilsPackage.AddComponent(new Product("10 Forks", 9.99f));
            utensilsPackage.AddComponent(new Product("10 Spoons", 9.99f));

            components.Add(razerGamingPackage);
            components.Add(utensilsPackage);

            PrintStuff.PrintAllComponents(components);

            Console.ReadLine();
        }
    }
}

