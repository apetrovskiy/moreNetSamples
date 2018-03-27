using System.Collections.Generic;

namespace FakesLib
{
    public sealed class SealedClass
    {
        public string StringData { get; set; }
        public static int IntData { get; set; }

        public IEnumerable<int> GetNumbers(int count)
        {
            var result = new List<int>();
            for (var i = 0; i < count; i++)
                result.Add(i);
            return result;
        }
    }
}
