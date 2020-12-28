using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Bridge
{
    public interface IPrinterImp
    {
        void Print(string text);
        void PrintLine(string text);
    }
}
