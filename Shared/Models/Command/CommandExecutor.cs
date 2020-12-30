using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Command
{
    public class CommandExecutor
    {
        private Stack<IUndoableCommand> _commands { get; } = new Stack<IUndoableCommand>();

        public void Execute(ICommand command, CommandArgs args = null)
        {
            if(command is IUndoableCommand undoableCommand)
            {
                Execute(undoableCommand, args);
            }
            else
            {
                command.Execute(args);
            }
        }

        public void UndoLastCommand()
        {
            if(_commands.TryPop(out IUndoableCommand command))
            {
                Console.WriteLine($"--- UNDOING {command.GetType().Name} COMMAND ---");
                command.Undo();
            }
        }

        private void Execute(IUndoableCommand command, CommandArgs args)
        {
            if (!command.IsValid(args)) return;

            _commands.Push(command);

            Console.WriteLine($"--- EXECUTING {command.GetType().Name} COMMAND ---");

            command.Execute(args);
        }
    }
}
