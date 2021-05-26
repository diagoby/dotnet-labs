using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    public class SessionTotal
    {
        public string Student { get; set; }
        public double Rating { get; set; }

        public override bool Equals(object obj) => 
            obj is SessionTotal total &&
            Student == total.Student &&
            Rating == total.Rating;

        public override int GetHashCode() => HashCode.Combine(Student, Rating);

        public override string ToString() => $"Student = {Student}, Rating = {Rating}";


    }

    public class DataProvider
    {
        public static IEnumerable<long> GetStudentsCodesByLetter(char letter)
        {
            return StudentsProvider.GetAll()
                .Where(student => student.LastName.StartsWith(letter))
                .Select(student => student.Code);
        }

        public static IEnumerable<string> GetgGroupsWithAtMostTwoStudentsWithMark(int mark)
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

        public static IEnumerable<SessionTotal> GetgStudentsAverageMarks()
        {
            var totals =
                from session in SessionsProvider.GetAll()
                group session by session.StudentCode into studentMarks
                join student in StudentsProvider.GetAll()
                on studentMarks.Key equals student.Code
                select new SessionTotal
                {
                    Student = student.LastName,
                    Rating = studentMarks.Average(s => s.TotalMark)
                };

            return
                from total in totals
                orderby 
                    total.Rating descending, 
                    total.Student
                select total;
        }
    }
}
