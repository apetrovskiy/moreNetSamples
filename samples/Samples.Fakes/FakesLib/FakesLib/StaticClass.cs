using System.Collections.Generic;

namespace FakesLib
{
    public static class StaticClass
    {
        public static string StringData { get; set; }
        public static int IntData { get; set; }

        public static IEnumerable<int> GetNumbers(int count)
        {
            var result = new List<int>();
            for (var i = 0; i < count; i++)
                result.Add(i);
            return result;
        }
    }
}
