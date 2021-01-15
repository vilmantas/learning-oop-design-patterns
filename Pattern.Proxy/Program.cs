using System;
using Shared.Models.Proxy;

namespace Pattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREATING FILE\r\n");

            var file = HugeFileFactory.CreateHugeFile("filePath", "fileName");
            

            Console.WriteLine($"FILE NAME: {file.FileName}");
            file.FileName = "Test file name";
            Console.WriteLine($"FILE PATH: {file.FilePath}");

            Console.WriteLine($"FILE SIZE: {file.GetFileSize()}\r\n");
            

            Console.WriteLine($"FILE NAME: {file.FileName}");
            Console.WriteLine($"FILE PATH: {file.FilePath}");

            Console.WriteLine($"FILE SIZE: {file.GetFileSize()}\r\n");


            Console.Read();
        }
    }
}
