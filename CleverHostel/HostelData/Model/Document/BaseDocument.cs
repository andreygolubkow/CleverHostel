// //CleverHostel->HostelData->IDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

using HostelData.Model.Student;

namespace HostelData.Model.Document
{
    /// <summary>
    /// Интерфейс документа.
    /// </summary>
    public class BaseDocument
    {

        protected BaseDocument()
        {
        }

        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата документа.
        /// </summary>
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// Очки начисляемые или снимаемые.
        /// </summary>
        public virtual int Points { get; set; }

        /// <summary>
        /// Комментарии к документу.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Заявитель
        /// </summary>
        public Applicant Applicant { get; set; }

        public virtual List<Student.Student> Students { get; set; }
    }
}