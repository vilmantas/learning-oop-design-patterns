using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class DefaultNameDisplayStrategy : INameDisplayStrategy
    {
        public string DisplayName(string name) => name;
    }
}
