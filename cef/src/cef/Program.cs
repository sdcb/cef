using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace cef
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("You need to manually delete this folder.");
            var folder = GetTemporaryDirectory();
            CreateDirectory(folder);
            OpenDirectory(folder);
        }

        public string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public DirectoryInfo CreateDirectory(string folder)
        {
            return Directory.CreateDirectory(folder);
        }

        public void OpenDirectory(string folder)
        {
            Process.Start(folder);
        }
    }
}
