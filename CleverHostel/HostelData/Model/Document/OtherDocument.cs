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
        private int _points;

        #region Overrides of BaseDocument

        /// <inheritdoc />
        public override int Points
        {
            get => _points;

            set
            {
                _points = value;
                OnPropertyChanged(nameof(Points));
            }
        }

        #endregion
    }
}
