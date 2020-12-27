using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Helpers
{
    public static class PrintStuff
    {
        public static void PrintAllComponents(List<IComponent> components)
        {
            foreach (var component in components)
            {
                ListComponents(component);
                Console.WriteLine();
            }
        }

        public static void ListComponents(IComponent component, int indentation = 0)
        {
            var isComposite = component.IsComposite();

            for (int i = 0; i < indentation * 4; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine($"{(indentation > 0 ? "> " : "")}{component.Name}. {(isComposite ? "Total: " : "Price: ")} {component.Price}.");

            if (isComposite)
            {
                foreach (var item in component.GetChildrenComponents())
                {
                    ListComponents(item, indentation + 1);
                }
            }
        }
    }
}
