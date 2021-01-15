using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Proxy
{
    public class HugeFileFactory
    {
        public static IHugeFile CreateHugeFile(string filePath, string fileName)
        {
            return new HugeFileProxy(fileName, filePath);
        }
    }
}
