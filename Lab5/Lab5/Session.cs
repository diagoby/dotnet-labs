using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Session
    {
        public long StudentCode { get; set; }

        public string Subject { get; set; }
        public int TotalMark { get; set; }
        public DateTime Date { get; set; }
        public SessionType Type { get; set; }
    }

    public enum SessionType
    {
        Test,
        Exam
    }
}
