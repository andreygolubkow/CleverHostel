// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Group.cs" company="andreygolubkow">
//   
// </copyright>
// <summary>
//   Группа.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Core.Model.Student
{
    using System;

    /// <summary>
    /// Группа.
    /// </summary>
    public class Group
    {
        private int _id;

        /// <summary>
        /// Идентификатор группы.
        /// </summary>
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
                    throw new ArgumentException("Id должен быть больше 0");
                }
                _id = value;
            }
        }

        /// <summary>
        /// Номер группы.
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// Факультет.
        /// </summary>
        public string Faculty { get; set; }

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
                    int groupYear = Convert.ToInt32(group[group.Length]);
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
    }
}