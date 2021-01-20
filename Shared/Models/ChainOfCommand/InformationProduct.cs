using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.ChainOfCommand
{
    public class InformationProduct
    {
        protected readonly InformationProduct Parent;

        protected readonly string Information;

        public InformationProduct(InformationProduct parent, string information)
        {
            Parent = parent;
            Information = information;
        }

        public virtual void HandleInformationRequest()
        {
            if(CanHandle())
            {
                Console.WriteLine("--- PRINTING INFO");
                PrintInformation();
            }
            else
            {
                Console.WriteLine("--- PASSING INFO REQUEST TO PARENT");
                Parent?.HandleInformationRequest();
            }
        }

        public virtual bool CanHandle() => !string.IsNullOrEmpty(Information);

        public virtual void PrintInformation() => Console.WriteLine(Information);
    }
}
