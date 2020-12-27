using Shared.Helpers;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var components = new List<IComponent>();

            components.Add(new Component("TV", 299.99f));
            components.Add(new Component("Radio", 19.99f));

            var razerPc = new Composite("Razer Gaming PC", 19.99f);
            razerPc.AddComponent(new Component("Razer PC Case", 59.99f, new AsteriskNameDisplayStrategy()));
            razerPc.AddComponent(new Component("Razer PC Leds", 29.99f, new AsteriskNameDisplayStrategy()));
            razerPc.AddComponent(new Component("Razer PC Fan", 19.99f, new AsteriskNameDisplayStrategy()));
            razerPc.AddComponent(new Component("Razer RGB Ram", 89.99f, new AsteriskNameDisplayStrategy()));

            var razerRig = new Composite("Razer Gaming PC Components", 99.99f);
            razerRig.AddComponent(new Component("Razer Gaming Mouse", 29.99f));
            razerRig.AddComponent(new Component("Razer Gaming Keyboard", 19.99f));
            razerRig.AddComponent(new Component("Razer Gaming Headset", 199.99f));
            razerRig.AddComponent(razerPc);


            var razerGamingPackage = new Composite("Razer Gaming Package", 99.99f);
            razerGamingPackage.AddComponent(new Component("Razer Gaming Char", 199.99f));
            razerGamingPackage.AddComponent(new Component("Razer Gaming 4K Monitor", 199.99f));
            razerGamingPackage.AddComponent(razerRig);

            var utensilsPackage = new Composite("Utensils Package", 2.99f);
            utensilsPackage.AddComponent(new Component("10 Knives", 9.99f, new HashedNameDisplayStrategy()));
            utensilsPackage.AddComponent(new Component("10 Forks", 9.99f, new HashedNameDisplayStrategy()));
            utensilsPackage.AddComponent(new Component("10 Spoons", 9.99f, new HashedNameDisplayStrategy()));

            components.Add(razerGamingPackage);
            components.Add(utensilsPackage);

            PrintStuff.PrintAllComponents(components);

            Console.ReadLine();
        }
    }
}
