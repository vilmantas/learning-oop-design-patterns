using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class AsteriskNameDisplayStrategy : INameDisplayStrategy
    {
        public string DisplayName(string name) => $"*{name}*";
    }
}
