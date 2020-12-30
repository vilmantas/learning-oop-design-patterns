using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public class CapitalizeTextCommand : IUndoableCommand
    {
        private readonly TextDocument _document;

        private string _previousState { get; set; }

        public CapitalizeTextCommand(TextDocument document)
        {
            _document = document;
        }

        public void Execute(CommandArgs args)
        {
            _previousState = _document.Text;
            _document.CapitalizeText();
        }

        public bool IsValid(CommandArgs args) => _document.Text.ToUpperInvariant() != _document.Text;

        public void Undo()
        {
            _document.Text = _previousState;
        }
    }
}
