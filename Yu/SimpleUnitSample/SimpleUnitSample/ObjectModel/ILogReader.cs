using System.Collections.Generic;

namespace SimpleUnitSample.ObjectModel
{
    public interface ILogReader
    {
        IEnumerable<string> Read(string path);
    }
}