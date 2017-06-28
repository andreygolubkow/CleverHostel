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
        #region Overrides of BaseDocument

        /// <inheritdoc />
        public override int Points { get; set; }

        #endregion
    }
}
