// //CleverHostel->Entities->Student.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model
{
    public class Student
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Room { get; set; }
        
        public string Department { get; set; }

        public int Course { get; set; }
        
        public string Group { get; set; }

        [InverseProperty("Students")]
        public virtual ICollection<IDocument> Documents { get; set; }
    } 
}
