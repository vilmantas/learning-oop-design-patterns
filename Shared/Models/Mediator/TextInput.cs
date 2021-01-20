using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models.Mediator.Abstract;

namespace Shared.Models.Mediator
{
    public class TextInput : IWorker
    {
        private readonly IDirector _director;

        private string Text { get; set; } = string.Empty;

        public TextInput(IDirector director)
        {
            _director = director;
        }

        private void Changed()
        {
            _director.OnChange(this);
        }

        public void Reset()
        {
            Text = string.Empty;
            Console.WriteLine("Input reset");
        }


        public void ChangeText(string newText)
        {
            Text = newText;
            Changed();
        }

        public string GetText()
        {
            return Text;
        }
    }
}
