using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayForeach
{
    class Dic
    {
        static Dictionary<int, int> _f = new Dictionary<int, int>();

        static Dictionary<int, int> _h = new Dictionary<int, int>();

        static void Main()
        {
            // Add items to dictionary.
            _f.Add(1, 2);
            _f.Add(2, 3);
            _f.Add(3, 4);

            // Use var in foreach loop.
            foreach (var pair in _f)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("C# program that uses var 2\n");
            // Add items to dictionary.
            _h.Add(5, 4);
            _h.Add(4, 3);
            _h.Add(2, 1);

            // Standard foreach loop.
            foreach (KeyValuePair<int, int> pair in _h)
            {
                Console.WriteLine("Key: {0}, Value:{1}", pair.Key, pair.Value);
            }

			string[] arr = new string[]
			{
				"One",
				"Two"
			};
			var dict = arr.ToDictionary(items => items, items => true);
			foreach (var pair in dict)
			{
				Console.WriteLine("{0}, {1}",
					pair.Key,
					pair.Value);
			}
        }
    }
}
