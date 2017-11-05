// //CleverHostel->HostelData->PromotionDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HostelData.Model.Student;

namespace HostelData.Model.Document
{
    /// <summary>
    /// Поощрение за какое либой полезное действие, обычно начисляются баллы.
    /// </summary>
    public class PromotionDocument : Document
    {

        private int _points;
        private string _name;

        /// <summary>
        /// Название поощрения.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        #region Implementation of Base

        
  /*      /// <summary>
        /// Очки начисляемые .
        /// </summary>
        public new int Points
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
        */

        #endregion

    }
}
