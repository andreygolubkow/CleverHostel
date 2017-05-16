﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Promotion.cs" company="andreygolubkow">
//   
// </copyright>
// <summary>
//   Поощрение за какое либой полезное действие, обычно начисляются баллы.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Model.Documents
{
    using System;

    /// <summary>
    /// Поощрение за какое либой полезное действие, обычно начисляются баллы.
    /// </summary>
    public class PromotionDocument : IDocument
    {
        private int _id;

        private DateTime _date;

        private int _points;

        /// <summary>
        /// Название поощрения.
        /// </summary>
        public string Name { get; set; }

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
                    throw new ArgumentException("Id должен быть больше 0");
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
                if ( value.Year < DateTime.Now.Year - 15 )
                {
                    throw new ArgumentException("Дата не актуальна.");
                }
                _date = value;
            }
        }

        /// <summary>
        /// Очки начисляемые .
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }

            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentException("Нельзя присвоить отрицательные баллы. Воспользуйтесь другим документом.");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Комментарии к документу.
        /// </summary>
        public string Comments { get; set; }

        #endregion

    }
}