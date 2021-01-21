using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Observer
{
    public class Observer<T>
    {
        private readonly Action<T> _action;

        private readonly Subject<T>.Subscription<T> _subscription;

        public Observer(Subject<T> subject,  Action<T> action)
        {
            _subscription = subject.Subscribe(action);
            _action = action;
        }

        public void Unsubscribe()
        {
            _subscription.Unsubscribe();
        }

        public virtual void Update(T state)
        {
            _action(state);
        }
    }
}
