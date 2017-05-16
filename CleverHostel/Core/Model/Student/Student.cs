// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="andreygolubkow">
// </copyright>
// <summary>
//   Студент.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
        /// Идентификатор группы.
        /// </summary>
        public int GroupId
        {
            get
            {
                return _groupId;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentException("Идентификатор группы не может быть меньше 0.");
                }
                _groupId = value;
            }
        }
    }
}
