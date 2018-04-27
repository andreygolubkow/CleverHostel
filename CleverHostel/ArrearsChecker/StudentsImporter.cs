using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;


namespace ArrearsChecker
{
    public static class StudentsImporter
    {

        public static ObservableCollection<Student> ReadStudents(string file)
        {
            string s = System.IO.File.ReadAllText(file);
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            CSVHelper csv = new CSVHelper(s,"\t");
            
            foreach(string[] line in csv)
            {
                if ( line[4].ToLower() != "активный" && line[4].ToLower() != "отчислен" )
                {
                    continue;
                }
                Student student = new Student();
                student.Name = line[0];
                student.Room = line[1];
                student.Arrear = Convert.ToDouble(line[2]);
                student.Group = line[3];
                student.Active = line[4].ToLower() == "активный";
                if ( line[5].Length > 0 )
                {
                    var dd = Convert.ToInt32(line[5].Split('.')[0]);
                    var mm = Convert.ToInt32(line[5].Split('.')[1]);
                    var yyyy = Convert.ToInt32(line[5].Split('.')[2]);
                    student.PayDay = new DateTime(yyyy,mm,dd);
                }

                student.Notes = line[6];
                students.Add(student);
            }

            return students;
        }

    }
}
