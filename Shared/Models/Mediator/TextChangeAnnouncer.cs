using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models.Mediator.Abstract;

namespace Shared.Models.Mediator
{
    public class TextChangeAnnouncer : IWorker
    {
        private readonly IDirector _director;

        public TextChangeAnnouncer(IDirector director)
        {
            _director = director;
        }

        public void HandleTextChange(string newText)
        {
            Console.WriteLine($"Text changed to: {newText}");
            _director.OnChange(this);
        }

    }
}
