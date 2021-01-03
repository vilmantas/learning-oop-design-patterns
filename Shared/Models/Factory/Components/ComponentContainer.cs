using Shared.Models.Factory.Components.Abstract;
using Shared.Models.Factory.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Factory.Components
{
    public class ComponentContainer
    {
        private readonly ComponentFactory _componentFactory;

        public List<ScrollbarComponent> Scrollbars { get; set; }

        public List<IconComponent> Icons { get; set; }

        public List<WindowComponent> Windows { get; set; }

        public ComponentContainer(ComponentFactory componentFactory) 
        {
            _componentFactory = componentFactory;
        }

        public void AddNewIcon()
        {
            Icons.Add(_componentFactory.CreateIconComponent());
        }

        public void AddNewScrollbar()
        {
            Scrollbars.Add(_componentFactory.CreateScrollbarComponent());
        }

        public void AddNewWindow()
        {
            Windows.Add(_componentFactory.CreateWindowComponent());
        }
    }
}
