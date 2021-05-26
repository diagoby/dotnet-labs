using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Student
    {
        public long Code { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }

        public override string ToString() => $"{Code}: {LastName} from {Group}";
    }
}
