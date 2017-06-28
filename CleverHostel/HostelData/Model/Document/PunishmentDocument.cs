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
        private int _points ;

        /// <summary>
        /// Вердикт.
        /// </summary>
        public Verdict Verdict { get; set; }

        /// <summary>
        /// Очки снимаемые.
        /// </summary>
        public override int Points
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
    }
}
