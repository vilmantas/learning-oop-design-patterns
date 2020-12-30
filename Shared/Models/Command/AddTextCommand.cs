using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public class AddTextCommand : IUndoableCommand
    {
        private readonly TextDocument _document;

        private string _previousState;

        public AddTextCommand(TextDocument document)
        {
            _document = document;
        }

        public void Execute(CommandArgs args)
        {
            if(!(args is AddTextCommandArgs textArgs)) return;

            _previousState = _document.Text;
            _document.AddText(textArgs.Text);
        }

        public bool IsValid(CommandArgs args) => args is AddTextCommandArgs textArgs && _document.Text + textArgs.Text != _document.Text;

        public void Undo()
        {
            _document.Text = _previousState;
        }
    }
}
