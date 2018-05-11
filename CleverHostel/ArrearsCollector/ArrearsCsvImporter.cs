using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

using ArrearsChecker;

using Newtonsoft.Json;

namespace ArrearsCollector
{
    public class ArrearsCsvImporter
    {

        public List<Student> ReadPvzData(string file)
        {
            //Формат файла - ФИО \t Долг
            var list = new List<Student>();
            string s = System.IO.File.ReadAllText(file);
            CSVHelper csv = new CSVHelper(s,"\t");
            foreach (string[] line in csv)
            {
                var student = new Student();
                student.Name = line[0];
                student.Arrear = Convert.ToDouble(line[1]);
                student.EducationForm = "ПВЗ";
                list.Add(student);
            }
            string json = JsonConvert.SerializeObject(list);
            using (var writer = new StreamWriter("pvz.json",false))
            {
                writer.Write(json);
            }
            return list;
        }

        public List<Student> ReadBudgetData(string file)
        {
            //Формат файла - ФИО \t Группа \t Статус \t Сумма
            var list = new List<Student>();
            string s = System.IO.File.ReadAllText(file);
            CSVHelper csv = new CSVHelper(s,"\t");
            foreach (string[] line in csv)
            {
                var student = new Student();
                student.Name = line[0];
                student.Group = line[1];
                student.Active = line[2];
                student.Arrear = Convert.ToDouble(line[3]);
                student.EducationForm = "Бюджет";
                list.Add(student);
            }
            string json = JsonConvert.SerializeObject(list);
            using (var writer = new StreamWriter("budget.json",false))
            {
                writer.Write(json);
            }
            return list;
        }

        public List<Student> ReadHostelData(string file)
        {
            //Формат файла - ФИО \t Комната \t Группа
            var list = new List<Student>();
            string s = System.IO.File.ReadAllText(file);
            CSVHelper csv = new CSVHelper(s,"\t");
            foreach (string[] line in csv)
            {
                var student = new Student();
                student.Name = line[0];
                student.Room = line[1];
                student.Group = line[2];
                list.Add(student);
            }
            string json = JsonConvert.SerializeObject(list);
            using (var writer = new StreamWriter("hostel.json",false))
            {
                writer.Write(json);
            }
            return list;
        }
    }
}
