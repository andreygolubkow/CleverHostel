// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Verdict.cs" company="andreygolubkow">
//   
// </copyright>
// <summary>
//   Набор вердиктов для взысканий.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Model.Documents
{
    /// <summary>
    /// Вердикт.
    /// </summary>
    public enum Verdict
    {
        /// <summary>
        /// Замечание.
        /// </summary>
       Comment = 0,
       /// <summary>
       /// Предупреждение.
       /// </summary>
       Warning = 1,
       /// <summary>
       /// Выговор.
       /// </summary>
       Rebuke = 3
    }
}