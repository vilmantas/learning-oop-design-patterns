using System;
using Shared.Models.Mediator;

namespace Pattern.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInputDirector director = new TextInputDirector();

            director.Input.ChangeText("New text");
        }
    }
}
