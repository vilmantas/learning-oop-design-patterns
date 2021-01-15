using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Proxy
{
    public class HugeFile : IHugeFile
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public double GetFileSize()
        {
            Console.WriteLine($"Getting file size from initialized file.");
            return 10f;
        }

        public HugeFile(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
