using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Memento
{
    public class TextConcatenator
    {
        private readonly List<string> _data = new List<string>();

        public TextConcatenator()
        {
            
        }

        public void AddText(string text)
        {
            _data.Add(text);
        }

        public void PrintText()
        {
            Console.WriteLine(string.Join(' ', _data));
        }

        public TextConcatenatorMemento CreateMemento()
        {
            return new TextConcatenatorMemento(_data.ToList());
        }

        public void SetMemento(TextConcatenatorMemento memento)
        {
            _data.Clear();
            _data.AddRange(memento.State);
        }

        public class TextConcatenatorMemento
        {
            protected internal List<string> State { get; }

            protected internal TextConcatenatorMemento(List<string> state)
            {
                State = state;
            }
        }
    }
}
