using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public interface ICommand
    {
        void Execute(CommandArgs args);
    }
}
