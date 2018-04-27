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

        public DateTime? PayDay = null;

        public string Notes { get; set; }

        public bool IsPayed => PayDay != null;
    }
}
