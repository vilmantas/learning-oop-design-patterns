using System;
using Shared.Models.Iterator;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedNodeList list = new SortedNodeList();
            list.AddValue(-10);
            list.AddValue(5);
            list.AddValue(10);
            list.AddValue(100);

            var iterator = list.GetIterator();

            iterator.InternalPrintTraverse();

            Console.Read();
        }
    }
}
