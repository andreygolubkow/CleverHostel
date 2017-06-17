using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelData.Model.Student
{
    public class Applicant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Department Department { get; set; }
    }
}
