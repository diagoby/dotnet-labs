using System;
using Lab4.lib;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedSet<int> set1 = new LinkedSet<int>(new[] { 2, 3, 4 });
            LinkedSet<int> set2 = LinkedSet<int>.Of(new[] { 2, 3 });
            LinkedSet<int> set3 = new LinkedSet<int>(new[] { -1 });

            bool modified = set3.AddAll(new[] { -1 });

            int[] arr = new int[5];
            set1.CopyTo(arr, -5);

            Console.WriteLine(string.Join(", ", arr));

            set2.Add(4);

            Console.WriteLine($"{set1.GetHashCode()},\n{set2.GetHashCode()}");
            Console.WriteLine(set1 - set2);
        }
    }
}
