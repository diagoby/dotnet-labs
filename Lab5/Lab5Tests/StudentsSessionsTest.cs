using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab5;

namespace Lab5Tests
{
    [TestClass]
    public class StudentsSessionsTest
    {
        [TestMethod]
        public void It_ShouldReturnStudentsCodesByLetter()
        {
            List<long> codesOnH = new List<long> { 444, 151515, 202020 };
            List<long> resultList = new List<long>(DataProvider.GetStudentsCodesByLetter('H'));
            CollectionAssert.AreEquivalent(codesOnH, resultList);
        }

        [TestMethod]
        public void It_ShouldReturnGroupsWithAtMostTwoStudentsWithMarkTwoOnExam()
        {
            List<string> groupsWithMarksTwo = new List<string> { "ST2" };

            /* Should be list with only groups where at most two students 
             * have mark "2" on exam (session type exam)
             */
            List<string> resultList = new List<string>(DataProvider.GetgGroupsWithAtMostTwoStudentsWithMark(2));

            CollectionAssert.AreEquivalent(groupsWithMarksTwo, resultList);
        }

        [TestMethod]
        public void It_ShouldReturnStudentsAverageMarks()
        {
            List<SessionTotal> studentsTotals = new List<SessionTotal> {
                new SessionTotal() { Student = "Blankenship", Rating = 5 },
                new SessionTotal() { Student = "Cole", Rating = 5 },
                new SessionTotal() { Student = "Doe", Rating = 5 },
                new SessionTotal() { Student = "Howard", Rating = 5 },
                new SessionTotal() { Student = "Ivanenko", Rating = 5 },
                new SessionTotal() { Student = "Lowery", Rating = 5 },
                new SessionTotal() { Student = "Marsh", Rating = 5 },
                new SessionTotal() { Student = "Mueller", Rating = 5 },
                new SessionTotal() { Student = "Petrenko", Rating = 5 },
                new SessionTotal() { Student = "Glover", Rating = 4 },
                new SessionTotal() { Student = "Hobbs", Rating = 4 },
                new SessionTotal() { Student = "Holmes", Rating = 4 },
                new SessionTotal() { Student = "Rodgers", Rating = 4 },
                new SessionTotal() { Student = "Norman", Rating = 3 },
                new SessionTotal() { Student = "Odonnell", Rating = 3 },
                new SessionTotal() { Student = "Walter", Rating = 3 },
                new SessionTotal() { Student = "Garrett", Rating = 2 },
                new SessionTotal() { Student = "Mccall", Rating = 2 },
                new SessionTotal() { Student = "Smith", Rating = 2 },
                new SessionTotal() { Student = "Solis", Rating = 2 }
            };

            /* 
             * Should be list with sesstions totals ordered by rating descending and name ascending
             */
            List<SessionTotal> resultList = new List<SessionTotal>(DataProvider.GetgStudentsAverageMarks());

            CollectionAssert.AreEqual(studentsTotals, resultList);
        }
    }
}
