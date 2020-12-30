using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public class AddTextCommandArgs : CommandArgs
    {
        public string Text { get; }

        public AddTextCommandArgs(string text)
        {
            Text = text;
        }
    }
}
