// //CleverHostel->HostelData->PunishmentDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HostelData.Model.Enums;
using HostelData.Model.Student;

namespace HostelData.Model.Document
{
    public class PunishmentDocument : Document
    {
        private int _points ;
        private Verdict _verdict;

        /// <summary>
        /// Вердикт.
        /// </summary>
        public Verdict Verdict
        {
            get
            {
                return _verdict;
            }
            set
            {
                _verdict = value;
            }
        }

      /*  /// <summary>
        /// Очки снимаемые.
        /// </summary>
        public new  int Points
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
        */

    }
}
