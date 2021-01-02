using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Weight { get; set; }

        public abstract void Apply(Visitor visitor);
    }
}
