using Shared.Models.Factory.Components.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Factory.Factories
{
    public abstract class ComponentFactory
    {
        public abstract IconComponent CreateIconComponent();
        public abstract ScrollbarComponent CreateScrollbarComponent();
        public abstract WindowComponent CreateWindowComponent();
    }
}
