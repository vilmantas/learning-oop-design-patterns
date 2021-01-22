using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shared.Models.State.States;

namespace Shared.Models.State
{
    public class PrinterContext
    {
        private PrinterState _state { get; set; }

        public PrinterContext()
        {
            _state = new PrinterStateClosed();
        }

        public void Open()
        {
            _state.Open(this);
        }

        public void Close()
        {
            _state.Close(this);
        }

        public void Print(string text)
        {
            _state.Print(this, text);
        }

        public void ChangeState(PrinterState state)
        {
            Console.WriteLine($"Changing state from: {_state.GetType().Name} ---  to: {state.GetType().Name}");
            _state = state;
        }
    }
}
