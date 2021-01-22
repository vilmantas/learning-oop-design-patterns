using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.State.States
{
    public abstract class PrinterState
    {
        public abstract void Open(PrinterContext context);
        public abstract void Close(PrinterContext context);
        public abstract void Print(PrinterContext context, string text);

        protected void ChangeState(PrinterContext context, PrinterState state)
        {
            context.ChangeState(state);
        }

    }
}
