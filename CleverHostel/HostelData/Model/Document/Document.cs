using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

using HostelData.Model.Student;

namespace HostelData.Model.Document
{

    public class Document
    {
        public virtual  Applicant Applicant { get; set; }
        public string Comments { get; set; }
        public DateTime DocumentDate { get; set; }
        public int Id { get; set; }
        [IgnoreDataMember]
        public  int Points { get; set; }
        public virtual List<Student.Student> Students { get; set; }
    }
}