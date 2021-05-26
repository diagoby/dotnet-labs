using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", DataProvider.GetStudentsCodesByLetter('H')));
            Console.WriteLine(string.Join(", ", DataProvider.GetgGroupsWithAtMostTwoStudentsWithMark(74)));
            Console.WriteLine(string.Join("\n", DataProvider.GetgStudentsAverageMarks()));
        }
    }
}
