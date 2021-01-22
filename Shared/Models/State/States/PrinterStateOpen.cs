using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shared.Models.State.States
{
    public class PrinterStateOpen : PrinterState
    {
        public override void Open(PrinterContext context)
        {
            throw new InvalidOperationException($"Already open.");
        }

        public override void Close(PrinterContext context)
        {
            context.ChangeState(new PrinterStateClosed());
        }

        public override void Print(PrinterContext context, string text)
        {
            context.ChangeState(new PrinterStateActive());
            Console.WriteLine("Waiting to print...");
            Thread.Sleep(1000);
            Console.WriteLine($"PRINTING: {text}");
            context.ChangeState(new PrinterStateOpen());
        }
    }
}
