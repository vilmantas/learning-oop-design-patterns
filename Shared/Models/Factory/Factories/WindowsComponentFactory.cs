using Shared.Models.Factory.Components.Abstract;
using Shared.Models.Factory.Components.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Factory.Factories
{
    public class WindowsComponentFactory : ComponentFactory
    {
        public override IconComponent CreateIconComponent()
        {
            return new WindowsIconComponent();
        }

        public override ScrollbarComponent CreateScrollbarComponent()
        {
            return new WindowsScrollbarComponent();
        }

        public override WindowComponent CreateWindowComponent()
        {
            return new WindowsWindowComponent();
        }
    }
}
