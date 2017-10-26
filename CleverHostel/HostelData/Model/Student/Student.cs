using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

using HostelData.Annotations;
using HostelData.Model.Document;
using HostelData.Model.Enums;

namespace HostelData.Model.Student
{
    /// <summary>
    /// Студент.
    /// </summary>
    [Table("Students")]
    public class Student: INotifyPropertyChanged
    {
        private int _id;

        private string _name;

        private int _groupId;

        private int _room;
        private Sex _sex;
        private string _phoneNumber;
        private Group _group;
        private ICollection<BaseDocument> _documents;

        public event PropertyChangedEventHandler PropertyChanged;

        public Student()
        {
            Visible = true;
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
                OnPropertyChanged(nameof(Id));
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
                OnPropertyChanged(nameof(Room));
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
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Пол студента.
        /// </summary>
        public Sex Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
                OnPropertyChanged(nameof(Sex));
            }
        }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Группа группы.
        /// </summary>
        public Group Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }

        /// <summary>
        /// Список документов для студента.
        /// </summary>
        public virtual ICollection<BaseDocument> Documents
        {
            get
            {
                return _documents;
            }
            set
            {
                _documents = value;
                OnPropertyChanged(nameof(Documents));
                OnPropertyChanged(nameof(Points));
            }
        }

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

        public bool Visible { get; set; }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
