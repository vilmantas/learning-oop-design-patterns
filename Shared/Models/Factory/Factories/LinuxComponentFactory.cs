using Shared.Models.Factory.Components.Abstract;
using Shared.Models.Factory.Components.Linux;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Factory.Factories
{
    public class LinuxComponentFactory : ComponentFactory
    {
        public override IconComponent CreateIconComponent()
        {
            return new LinuxIconComponent();
        }

        public override ScrollbarComponent CreateScrollbarComponent()
        {
            return new LinuxScrollbarComponent();
        }

        public override WindowComponent CreateWindowComponent()
        {
            return new LinuxWindowComponent();
        }
    }
}
