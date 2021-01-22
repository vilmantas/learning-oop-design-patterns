using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.State.States
{
    public class PrinterStateActive : PrinterState
    {
        public override void Open(PrinterContext context)
        {
            throw new InvalidOperationException("Wait for printing to finish.");
        }

        public override void Close(PrinterContext context)
        {
            throw new InvalidOperationException("Wait for printing to finish.");
        }

        public override void Print(PrinterContext context, string text)
        {
            throw new InvalidOperationException("Wait for printing to finish.");
        }
    }
}
