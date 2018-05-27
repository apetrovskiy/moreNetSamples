using System.Collections.Generic;

namespace FakesLib
{
    public class Class1
    {
        public string StringData { get; set; }
        public int IntData { get; set; }

        public IEnumerable<int> GetNumbers(int count)
        {
            var result = new List<int>();
            for (var i = 0; i < count; i++)
                result.Add(i);
            return result;
        }
    }
}
