using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
        bool IsValid(CommandArgs args);
    }
}
