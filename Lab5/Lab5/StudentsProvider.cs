using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class StudentsProvider
    {
        public static IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student() { Code = 111, LastName = "Petrenko", Group = "ST1" },
                new Student() { Code = 222, LastName = "Ivanenko", Group = "ST1" },
                new Student() { Code = 333, LastName = "Smith", Group = "ST1" },
                new Student() { Code = 444, LastName = "Holmes", Group = "ST2" },
                new Student() { Code = 555, LastName = "Doe", Group = "ST3" },

                new Student() { Code = 666, LastName = "Garrett", Group = "ST1" },
                new Student() { Code = 777, LastName = "Norman", Group = "ST1" },
                new Student() { Code = 888, LastName = "Cole", Group = "ST2" },
                new Student() { Code = 999, LastName = "Glover", Group = "ST2" },
                new Student() { Code = 101010, LastName = "Odonnell", Group = "ST3" },

                new Student() { Code = 111111, LastName = "Solis", Group = "ST1" },
                new Student() { Code = 121212, LastName = "Mueller", Group = "ST1" },
                new Student() { Code = 131313, LastName = "Blankenship", Group = "ST2" },
                new Student() { Code = 141414, LastName = "Rodgers", Group = "ST2" },
                new Student() { Code = 151515, LastName = "Hobbs", Group = "ST3" },

                new Student() { Code = 161616, LastName = "Walter", Group = "ST1" },
                new Student() { Code = 171717, LastName = "Marsh", Group = "ST1" },
                new Student() { Code = 181818, LastName = "Mccall", Group = "ST2" },
                new Student() { Code = 191919, LastName = "Lowery", Group = "ST2" },
                new Student() { Code = 202020, LastName = "Howard", Group = "ST3" }
            };
        }
    }
}
