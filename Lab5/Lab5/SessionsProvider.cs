using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class SessionsProvider
    {
        public static IEnumerable<Session> GetAll()
        {
            return new List<Session>
            {
                new Session() { StudentCode = 111, Subject = "Math", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 222, Subject = "Math", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 333, Subject = "Physics", TotalMark = 2, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 444, Subject = "OOP", TotalMark = 4, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 555, Subject = "Physics", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 666, Subject = "Chemistry", TotalMark = 2, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 777, Subject = "History", TotalMark = 3, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 888, Subject = "Electronics", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 999, Subject = "Math", TotalMark = 4, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 101010, Subject = "OOP", TotalMark = 3, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 111111, Subject = "Algorithms", TotalMark = 2, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 121212, Subject = "Databases", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 131313, Subject = "Modeling", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 141414, Subject = "Physics", TotalMark = 4, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 141414, Subject = "Math", TotalMark = 4, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 151515, Subject = "Math", TotalMark = 4, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 161616, Subject = "Algorithms", TotalMark = 3, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 171717, Subject = "Electronics", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 181818, Subject = "Databases", TotalMark = 2, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 191919, Subject = "Modeling", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 202020, Subject = "OOP", TotalMark = 5, Date = DateTime.Today, Type = SessionType.Test }
            };
        }
    }
}
