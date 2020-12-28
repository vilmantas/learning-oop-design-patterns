using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shared.Models.Bridge
{
    public class FilePrinterImp : IPrinterImp
    {
        private long _timestamp { get; }

        private string _path
        {
            get => $"{_timestamp}.txt";
        }

        public FilePrinterImp()
        {
            _timestamp = DateTimeOffset.UtcNow.UtcTicks;
            File.AppendAllText($"{_timestamp}.txt", string.Empty);
        }

        public void Print(string text)
        {
            File.AppendAllText(_path, text);
        }

        public void PrintLine(string text)
        {
            File.AppendAllLines(_path, new List<string>() {text});
        }
    }
}
