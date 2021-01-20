using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models.Mediator.Abstract;

namespace Shared.Models.Mediator
{
    public class TextInputDirector : IDirector
    {
        public readonly TextChangeAnnouncer Announcer;
        public readonly TextInput Input;

        public TextInputDirector()
        {

            // Initialization. 

            Input = new TextInput(this);
            Announcer = new TextChangeAnnouncer(this);
        }

        public void OnChange(IWorker worker)
        {
            if(worker == Input)
            {
                var newText = Input.GetText();
                Announcer.HandleTextChange(newText);
            } 
            else if(worker == Announcer)
            {
                Input.Reset();
            }
        }
    }
}
