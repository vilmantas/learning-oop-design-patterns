using System;
using Shared.Models.State;

namespace Pattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterContext ctx = new PrinterContext();

            ctx.Open();

            ctx.Print("Allah");

            ctx.Close();
        }
    }
}
