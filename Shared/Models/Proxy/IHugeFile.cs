using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Proxy
{
    public interface IHugeFile
    {
        string FileName { get; set; }
        string FilePath { get; set; }

        double GetFileSize();
    }
}
