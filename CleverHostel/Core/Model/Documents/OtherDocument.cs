// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OtherDocument.cs" company="andreygolubkow">
//   
// </copyright>
// <summary>
//   Другой документ. Можно снимать баллы, и начислять баллы.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Model.Documents
{
    using System;

    /// <summary>
    /// Другой документ. Можно снимать баллы, и начислять баллы.
    /// </summary>
    public class OtherDocument : IDocument
    {
        private int _id;

        private DateTime _date;

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
                if ( value < 0 )
                {
                    throw new ArgumentException("Ошибка. Идентификатор не может быть отрицательным.");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Дата документа.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

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

        #endregion
    }
}