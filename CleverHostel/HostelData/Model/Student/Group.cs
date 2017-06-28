// //CleverHostel->HostelData->Group.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HostelData.Model.Student
{
    [Table("StudentGroups")]
    public sealed class Group
    {

        /// <summary>
        /// Идентификатор группы.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Номер группы.
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// Факультет.
        /// </summary>
        public string Faculty { get; set; }

        public ICollection<Student> Students { get; set; }

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
    }
}
