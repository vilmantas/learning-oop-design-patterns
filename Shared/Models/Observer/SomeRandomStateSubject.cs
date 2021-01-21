using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Observer
{
    public class SomeRandomStateSubject : Subject<SomeRandomStateSubject>
    {
        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                Notify(this);
            }
        }

        public SomeRandomStateSubject()
        {
        }
    }
}
