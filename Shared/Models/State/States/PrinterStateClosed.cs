using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.State.States
{
    public class PrinterStateClosed : PrinterState
    {
        public override void Open(PrinterContext context)
        {
            context.ChangeState(new PrinterStateOpen());
        }

        public override void Close(PrinterContext context)
        {
            throw new InvalidOperationException("Already closed.");
        }

        public override void Print(PrinterContext context, string text)
        {
            throw new InvalidOperationException("Cannot print when printer is closed.");
        }
    }
}
