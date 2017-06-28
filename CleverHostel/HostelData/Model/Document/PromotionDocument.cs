// //CleverHostel->HostelData->PromotionDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HostelData.Model.Document
{
    /// <summary>
    /// Поощрение за какое либой полезное действие, обычно начисляются баллы.
    /// </summary>
    public class PromotionDocument : BaseDocument
    {

        private int _points;

        /// <summary>
        /// Название поощрения.
        /// </summary>
        public string Name { get; set; }

        #region Implementation of Base

        /// <summary>
        /// Очки начисляемые .
        /// </summary>
        public override int Points
        {
            get => _points;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Нельзя присвоить отрицательные баллы. Воспользуйтесь другим документом.");
                }
                _points = value;
            }
        }


        #endregion

    }
}
