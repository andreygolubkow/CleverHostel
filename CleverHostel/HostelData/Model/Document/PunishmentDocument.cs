// //CleverHostel->HostelData->PunishmentDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HostelData.Model.Enums;

namespace HostelData.Model.Document
{
    public class PunishmentDocument : BaseDocument
    {
        private int _id;

        private DateTime _date;

        private int _points;

        private string _comments;

        /// <summary>
        /// Вердикт.
        /// </summary>
        public Verdict Verdict { get; set; }

        #region Implementation of IDocument

        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
        public  int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Идентификатор взыскания не может быть отрицательным.");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Дата документа.
        /// </summary>
        public DateTime DocumentDate
        {
            get
            {
                return _date;
            }
            set
            {
                if (value.Year < DateTime.Now.Year - 15)
                {
                    throw new ArgumentException("Дата не актуальна.");
                }
                _date = value;
            }
        }

        /// <summary>
        /// Очки снимаемые.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (value > 0)
                {
                    throw new ArgumentException("Ошибка в выставлении баллов. Нельзя использовать положительные баллы.");
                }
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
