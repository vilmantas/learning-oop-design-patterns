using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class HashedNameDisplayStrategy : INameDisplayStrategy
    {
        public string DisplayName(string name) => name.GetHashCode().ToString();
    }
}
