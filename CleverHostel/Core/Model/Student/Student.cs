// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="andreygolubkow">
// </copyright>
// <summary>
//   Студент.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using Core.Model.Documents;

namespace Core.Model.Student
{
    using System;

    /// <summary>
    /// Студент.
    /// </summary>
    public class Student
    {
        private int _id;

        private string _name;

        private int _groupId;

        private int _room;

        public Student()
        {
            Documents = new List<IDocument>();
        }

        /// <summary>
        /// Уникальный идентификатор студента.
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
                    throw new ArgumentException("Идентификатор должен быть >0");
                }
                _id = value;
            }
        }

        public int Room
        {
            get
            {
                return _room;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentException("Комната не может быть отрицательной.");
                }
                _room = value;
            }
        }

        /// <summary>
        /// ФИО Студента.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Нельзя сделать имя пустым.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Пол студента.
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Группа группы.
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Список документов для студента.
        /// </summary>
        public List<IDocument> Documents { get; set; }

        public int Points
        {
            get
            {
                int startPoints = 0;
                foreach (var document in Documents)
                {
                    startPoints += document.Points;
                }
                return startPoints;
            }
        }
    }
}
