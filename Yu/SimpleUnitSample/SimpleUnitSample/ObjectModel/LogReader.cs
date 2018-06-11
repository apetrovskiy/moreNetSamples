using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitSample.ObjectModel
{
    public class LogReader : ILogReader
    {
        public IEnumerable<string> Read(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException("File not found: " + path);
            return File.ReadAllLines(path);            
        }
    }
}
