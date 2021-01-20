using System;
using Shared.Models.Memento;

namespace Pattern.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            TextConcatenator concatenator = new TextConcatenator();

            Console.WriteLine();
            Console.WriteLine("Adding text \"Hello\"");
            concatenator.AddText("Hello");

            Console.WriteLine();
            Console.WriteLine("Saving state...");
            var midState = concatenator.CreateMemento();

            Console.WriteLine();
            Console.WriteLine("Adding text \"World!\"");
            concatenator.AddText("World!");

            Console.WriteLine();
            Console.WriteLine("Printing state...");
            concatenator.PrintText();

            Console.WriteLine();
            Console.WriteLine("Resetting to first state");
            concatenator.SetMemento(midState);

            Console.WriteLine();
            Console.WriteLine("Adding text \"Developer!\"");
            concatenator.AddText("Developer!");

            Console.WriteLine();
            Console.WriteLine("Printing state...");
            concatenator.PrintText();
        }
    }
}
