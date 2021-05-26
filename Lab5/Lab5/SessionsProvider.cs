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
                new Session() { StudentCode = 111, Subject = "Math", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 222, Subject = "Math", TotalMark = 74, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 333, Subject = "Physics", TotalMark = 74, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 444, Subject = "OOP", TotalMark = 82, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 555, Subject = "Physics", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 666, Subject = "Chemistry", TotalMark = 60, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 777, Subject = "History", TotalMark = 72, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 888, Subject = "Electronics", TotalMark = 92, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 999, Subject = "Math", TotalMark = 65, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 101010, Subject = "OOP", TotalMark = 72, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 111111, Subject = "Algorithms", TotalMark = 80, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 121212, Subject = "Databases", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 131313, Subject = "Modeling", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 141414, Subject = "Physics", TotalMark = 93, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 141414, Subject = "Math", TotalMark = 93, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 151515, Subject = "Math", TotalMark = 74, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 161616, Subject = "Algorithms", TotalMark = 80, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 171717, Subject = "Electronics", TotalMark = 93, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 181818, Subject = "Databases", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Exam },
                new Session() { StudentCode = 191919, Subject = "Modeling", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Test },
                new Session() { StudentCode = 202020, Subject = "OOP", TotalMark = 90, Date = DateTime.Today, Type = SessionType.Test }
            };
        }
    }
}
