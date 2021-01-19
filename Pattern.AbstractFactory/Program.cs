using Shared.Models.Factory.Factories;
using Shared.Models.Factory.Components;

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
