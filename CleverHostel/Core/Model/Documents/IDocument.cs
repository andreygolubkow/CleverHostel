// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDocument.cs" company="andreygolubkow">
//   
// </copyright>
// <summary>
//   Интерфейс документа.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Core.Model.Documents
{
    using System;

    /// <summary>
    /// Интерфейс документа.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Дата документа.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Очки начисляемые или снимаемые.
        /// </summary>
        int Points { get; set; }

        /// <summary>
        /// Комментарии к документу.
        /// </summary>
        string Comments { get; set; }
    }
}
