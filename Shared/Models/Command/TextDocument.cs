using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public class TextDocument
    {
        public string Text { get; set; }

        public void AddText(string text)
        {
            Text += text;
        }

        public void CapitalizeText()
        {
            Text = Text.ToUpperInvariant();
        }


        public AddTextCommand CreateAddTextCommand() => new AddTextCommand(this);

        public CapitalizeTextCommand CreateCapitalizeTextCommand() => new CapitalizeTextCommand(this);
    }
}
