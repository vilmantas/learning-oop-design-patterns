using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Observer
{
    public class Subject<T>
    {

        private readonly Dictionary<Guid, Observer<T>> _observers;

        private readonly Dictionary<Guid, Action<T>> _actions;

        public Subject()
        {
            _observers = new Dictionary<Guid, Observer<T>>();
            _actions = new Dictionary<Guid, Action<T>>();
        }

        public Subscription<T> Subscribe(Observer<T> observer)
        {
            var id = Guid.NewGuid();

            _observers.Add(id, observer);

            return new Subscription<T>(id, this);
        }

        public Subscription<T> Subscribe(Action<T> observer)
        {
            var id = Guid.NewGuid();

            _actions.Add(id, observer);

            return new Subscription<T>(id, this);
        }

        public void Unsubscribe(Guid id)
        {
            _actions.Remove(id);
            _observers.Remove(id);
        }

        public void Notify(T state)
        {
            foreach(Observer<T> observer in _observers.Values)
            {
                observer.Update(state);
            }

            foreach(Action<T> action in _actions.Values)
            {
                action(state);
            }
        }



        public class Subscription<V>
        {
            private readonly Guid _id;

            private readonly Subject<V> _subject;

            public Subscription(Guid id, Subject<V> subject)
            {
                _id = id;
                _subject = subject;
            }

            public void Unsubscribe()
            {
                _subject.Unsubscribe(_id);
            }
        }
    }
}
