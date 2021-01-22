using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.TemplateMethod
{
    public class FilePrinter : Printer
    {

        private readonly string _fileName;

        public FilePrinter()
        {
            _fileName = DateTime.Now.Ticks.ToString();
        }

        public override bool CanPrint()
        {
            return File.Exists(_fileName);
        }

        public override void DoCleanup()
        {
            var fs = File.Create("AFTER WORK NAME.txt");
            fs.Close();
            File.Replace(_fileName, "AFTER WORK NAME.txt", "backup.txt");
        }

        public override void DoSetup()
        {
            var fs = File.Create(_fileName);
            fs.Close();
        }

        public override void DoPrint()
        {
            File.WriteAllText(_fileName, "test string");
        }

        public override void DoDebug()
        {
            Console.WriteLine($"File exists?: {File.Exists(_fileName)}, File creation date: {File.GetCreationTime(_fileName)}");
        }
    }
}
