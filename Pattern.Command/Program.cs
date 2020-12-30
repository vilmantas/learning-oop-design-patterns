using System;
using Shared.Models.Command;

namespace Pattern.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new TextDocument();

            var executor = new CommandExecutor();

            Console.WriteLine(doc.Text);

            executor.Execute(doc.CreateAddTextCommand(), new AddTextCommandArgs("Hella fun"));

            Console.WriteLine(doc.Text);

            executor.Execute(doc.CreateCapitalizeTextCommand());

            Console.WriteLine(doc.Text);

            executor.Execute(doc.CreateAddTextCommand(), new AddTextCommandArgs(" to be a nice person"));

            Console.WriteLine(doc.Text);

            executor.Execute(doc.CreateAddTextCommand(), new AddTextCommandArgs("")); // Shouldn't be executed

            executor.Execute(doc.CreateCapitalizeTextCommand());

            Console.WriteLine(doc.Text);

            Console.WriteLine();
            Console.WriteLine(" ---- ---- ---- ");
            Console.WriteLine();

            executor.UndoLastCommand();

            Console.WriteLine(doc.Text);

            executor.UndoLastCommand();

            Console.WriteLine(doc.Text);

            executor.Execute(doc.CreateAddTextCommand(), new AddTextCommandArgs(" !!!!!"));

            Console.WriteLine(doc.Text);

            executor.UndoLastCommand();

            Console.WriteLine(doc.Text);

            Console.Read();
        }
    }
}
