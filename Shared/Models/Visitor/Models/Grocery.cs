using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Visitor.Models
{
    public class Grocery : Product
    {
        public bool IsUpmarket { get; set; }

        public override void Apply(Visitor visitor)
        {
            visitor.VisitGrocery(this);
        }
    }
}
