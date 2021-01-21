using System;
using Shared.Models.Observer;

namespace Pattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeRandomStateSubject randomStateSubject = new SomeRandomStateSubject();

            var subscription = randomStateSubject.Subscribe(x => Console.WriteLine($"Action subscription #1 notification: {x.Text}"));

            randomStateSubject.Subscribe(x => Console.WriteLine($"Action subscription #2 notification: {x.Text}"));

            randomStateSubject.Text = "New value";

            subscription.Unsubscribe();

            randomStateSubject.Text = "Unseen by #1 value";

            var observer = new Observer<SomeRandomStateSubject>(randomStateSubject, x => Console.WriteLine($"Observer Action: {x.Text}"));

            randomStateSubject.Subscribe(observer);

            randomStateSubject.Text = "New random value";

            observer.Unsubscribe();

            randomStateSubject.Text = "Unseen by observer";


        }

        public class State
        {
            public string Value { get; set; }
        }
    }
}
