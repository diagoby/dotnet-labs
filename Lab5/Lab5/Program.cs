using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", GetStudentsCodesByLetter('H')));
            Console.WriteLine(string.Join(", ", GetgGroupsWithAtMostTwoStudentsWithMark(74)));
            Console.WriteLine(string.Join("\n", GetgStudentsAverageMarks()));
        }

        static IEnumerable<long> GetStudentsCodesByLetter(char letter)
        {
            return StudentsProvider.GetAll()
                .Where(student => student.LastName.StartsWith(letter))
                .Select(student => student.Code);
        }

        static IEnumerable<string> GetgGroupsWithAtMostTwoStudentsWithMark(int mark)
        {
            return
                from student in StudentsProvider.GetAll()
                join session in SessionsProvider.GetAll()
                on student.Code equals session.StudentCode
                where
                    session.TotalMark.Equals(mark)
                && session.Date.Year.Equals(DateTime.Today.Year)
                && session.Type.Equals(SessionType.Exam)
                group student by student.Group into studentsByGroup
                where studentsByGroup.Count() <= 2
                select studentsByGroup.Key;
        }

        static IEnumerable<string> GetgStudentsAverageMarks()
        {
            var totals = 
                from session in SessionsProvider.GetAll()
                group session by session.StudentCode into studentMarks
                join student in StudentsProvider.GetAll()
                on studentMarks.Key equals student.Code
                select new
                {
                    Student = student.LastName,
                    Rating = studentMarks.Average(s => s.TotalMark)
                };

            return 
                from total in totals
                orderby total.Rating descending
                select $"{total.Student} - {total.Rating}";
        }
    }
}
