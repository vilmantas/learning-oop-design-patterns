using System;
using Shared.Models.Iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree list = new BinaryTree();
            list.AddValue(-10);
            list.AddValue(5);
            list.AddValue(-20);
            list.AddValue(10);
            list.AddValue(3);
            list.AddValue(100);
            list.AddValue(30);
            list.AddValue(-11);

            var iterator = list.GetIterator();

            Console.WriteLine("");
            Console.WriteLine("--- Internal Depth-First Iterator (print once max depth is reached)  ---");
            Console.WriteLine("");

            iterator.InternalPrintTraverse();

            Console.WriteLine("");
            Console.WriteLine("--- C# Standard External Depth-First Iterator (print as you go) ---");
            Console.WriteLine("");

            foreach (Node node in list)
            {
                Console.WriteLine(node.Value);
            }

            Console.WriteLine("");
            Console.WriteLine("--- As per book External Depth-First Iterator (print as you go)  ---");
            Console.WriteLine("");

            for (iterator.First(); !iterator.IsDone() ; iterator.Next())
            {
                Node node = iterator.CurrentItem();
                Console.WriteLine(node.Value);
            }

            Console.Read();
        }
    }
}
