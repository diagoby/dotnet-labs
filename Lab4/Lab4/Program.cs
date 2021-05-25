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

            int[] arr = new int[5];
            set1.CopyTo(arr, -5);

            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(set1 - set2);
        }
    }
}
