using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.TemplateMethod
{
    public abstract class Printer
    {
        public abstract bool CanPrint();

        public abstract void DoCleanup();

        public abstract void DoSetup();

        public abstract void DoPrint();

        public abstract void DoDebug();

        public void Print()
        {
            Console.WriteLine("Calling setup from template...");
            DoSetup();
            Console.WriteLine("Checking if printing is available from template...");
            if(CanPrint())
            {
                Console.WriteLine("Calling print from template...");
                DoPrint();
                Console.WriteLine("Calling cleanup from template...");
                DoCleanup();
            }
            else
            {
                Console.WriteLine("Calling debug from template...");
                DoDebug();
            }
        }
    }
}
