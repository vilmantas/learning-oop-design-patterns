using System;
using Shared.Models.TemplateMethod;

namespace Pattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new FilePrinter();

            p.Print();
        }
    }
}
