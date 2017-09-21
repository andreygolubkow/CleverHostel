// //CleverHostel->HostelData->Group.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

using HostelData.Annotations;

namespace HostelData.Model.Student
{
    [Table("StudentGroups")]
    public sealed class Group: INotifyPropertyChanged
    {
        private int _id;
        private string _num;
        private string _faculty;
        private ICollection<Student> _students;


        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Идентификатор группы.
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
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        /// <summary>
        /// Номер группы.
        /// </summary>
        public string Num
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value;
                OnPropertyChanged(nameof(Num));
                OnPropertyChanged(nameof(Course));
            }
        }

        /// <summary>
        /// Факультет.
        /// </summary>
        public string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
                OnPropertyChanged(nameof(Faculty));
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        /// <summary>
        /// Курс, вычисляется автоматически.
        /// </summary>
        public int Course
        {
            get
            {
                string group = Num;

                //Если есть подгруппы.
                if ( group.Length > 3 )
                {
                    group = group.Substring(0, 3);
                }
                var course = 0;
                try
                {
                    string groupLitera = ""+group[group.Length - 1];
                    int groupYear = Convert.ToInt32(groupLitera);
                    int nowYear = DateTime.Now.Year % 10;
                    course = Math.Abs(nowYear - groupYear);
                    //Если сейчас август, то учитываем перевод на новый курс.
                    if ( DateTime.Now.Month >= 8 )
                    {
                        course++;
                    }
                }
                catch ( Exception )
                {
                    course = 0;
                }
                return course;
            }
        }


        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Overrides of Object

        /// <inheritdoc />
        public override string ToString()
        {
            return Num;
        }

        #endregion
    }
}
