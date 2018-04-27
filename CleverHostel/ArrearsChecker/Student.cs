using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace ArrearsChecker
{
    public class Student
    {
        public string Name { get; set; }

        public string Room { get; set; }

        public double Arrear {get; set; }

        public string Group { get; set; }

        public bool Active { get; set; }

        public List<DateTime> PayDays = new List<DateTime>();

        public string Notes { get; set; }

        public bool IsPayed => PayDays!=null && PayDays.Count > 0;
    }
}
