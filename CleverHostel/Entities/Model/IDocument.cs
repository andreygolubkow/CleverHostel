// //CleverHostel->Entities->Document.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model
{
    public interface IDocument
    {
        int Id { get; set; }

        DateTime Date { get; set; }

        string Comments { get; set; }

        [InverseProperty("Documents")]
        ICollection<Student> Students { get; set; }
    }
}
