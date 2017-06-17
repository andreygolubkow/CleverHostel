// //CleverHostel->HostelData->OtherDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HostelData.Model.Document
{
    /// <summary>
    /// Другой документ. Можно снимать баллы, и начислять баллы.
    /// </summary>
    public class OtherDocument : BaseDocument
    {
        private int _id;

        private int _points;

        private string _comments;

        #region Implementation of IDocument

        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ошибка. Идентификатор не может быть отрицательным.");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Дата документа.
        /// </summary>
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// Очки начисляемые или снимаемые.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        /// <summary>
        /// Комментарии к документу.
        /// </summary>
        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                _comments = value;
            }
        }

        /// <inheritdoc />
        public List<Student.Student> Students { get; set; }

        #endregion
    }
}
