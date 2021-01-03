using Shared.Models.Factory.Components;
using Shared.Models.Factory.Factories;
using System;

namespace Pattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentFactory componentFactory = new WindowsComponentFactory();

            ComponentContainer container = new ComponentContainer(componentFactory);

            container.AddNewIcon();
            container.AddNewScrollbar();
            container.AddNewScrollbar();
            container.AddNewWindow();
        }
    }
}
