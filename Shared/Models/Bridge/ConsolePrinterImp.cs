using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Bridge
{
    public class ConsolePrinterImp : IPrinterImp
    {
        public void Print(string text)
        {
            Console.Write(text);
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);

        }
    }
}
