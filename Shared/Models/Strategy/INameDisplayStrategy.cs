using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public interface INameDisplayStrategy
    {
        string DisplayName(string name);
    }
}
