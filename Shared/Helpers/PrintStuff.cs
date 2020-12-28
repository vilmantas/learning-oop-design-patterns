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
                PrintComponent(component);
                Console.WriteLine();
            }
        }

        public static void PrintComponent(IComponent component, int indentation = 0)
        {
            component.Print(indentation);

            if(!component.IsComposite()) return;

            foreach (var item in component.GetChildrenComponents())
            {
                PrintComponent(item, indentation + 1);
            }
        }
    }
}
