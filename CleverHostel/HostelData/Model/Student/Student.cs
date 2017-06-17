using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using HostelData.Model.Document;
using HostelData.Model.Enums;

namespace HostelData.Model.Student
{
    /// <summary>
    /// Студент.
    /// </summary>
    [Table("Students")]
    public class Student
    {
        private int _id;

        private string _name;

        private int _groupId;

        private int _room;

        public Student()
        {
            //Documents = new List<BaseDocument>();
        }

        /// <summary>
        /// Уникальный идентификатор студента.
        /// </summary>
        [Key]
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                if (value < 0)
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
                if (value < 0)
                {
                    throw new ArgumentException("Комната не может быть отрицательной.");
                }
                _room = value;
            }
        }

        /// <summary>
        /// ФИО Студента.
        /// </summary>
        [Required]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length == 0)
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
        /// Номер телефона.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Группа группы.
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Список документов для студента.
        /// </summary>
        public virtual ICollection<BaseDocument> Documents { get; set; }

        public int Points
        {
            get
            {
                if ( Documents == null )
                {
                    return 0;
                }

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
