using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Proxy
{
    public class HugeFileProxy : IHugeFile
    {
        private string _fileName;
        private string _filePath;
        public string FileName
        {
            get
            {
                Console.WriteLine($"Get File Name operation on proxy. ... Is File initialized: {_hugeFile.IsValueCreated}");
                
                return _hugeFile.IsValueCreated ? _hugeFile.Value.FileName : _fileName;
            }
            set
            {
                if (_hugeFile != null && _hugeFile.IsValueCreated)
                {
                    _hugeFile.Value.FileName = value;
                }
                else
                {
                    _fileName = value;
                }
            }
        }

        public string FilePath
        {
            get
            {
                Console.WriteLine($"Get File Path operation on proxy. ... Is File initialized: {_hugeFile.IsValueCreated}");

                return _hugeFile.IsValueCreated ? _hugeFile.Value.FilePath : _filePath;
            }
            set
            {
                if(_hugeFile != null && _hugeFile.IsValueCreated)
                {
                    _hugeFile.Value.FilePath = value;
                }
                else
                {
                    _filePath = value;
                }
            }
        }

        public double GetFileSize()
        {
            Console.WriteLine($"Getting file size by proxy. ... Is File initialized: {_hugeFile.IsValueCreated}");
            return _hugeFile.Value.GetFileSize();
        }

        private readonly Lazy<HugeFile> _hugeFile;
        public HugeFileProxy(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
            _hugeFile = new Lazy<HugeFile>(() => new HugeFile(FileName, FilePath));
        }

        
    }
}
