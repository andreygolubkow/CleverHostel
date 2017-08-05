using System;
using System.Collections.Generic;

using HostelData.DataBase;

using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Windows;

using HostelData.Model.Document;
using HostelData.Model.Enums;
using HostelData.Model.Student;

using static System.Configuration.ConfigurationSettings;

namespace HostelWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HostelContext _dataBase;

        public MainWindow()
        {
            InitializeComponent();
            _dataBase = new HostelContext(AppSettings["HostelModel"]);
            LoadData();
        }

        private void LoadData()
        { 
            //InitialData(_dataBase);

            _dataBase.Students.Include(s=>s.Group).Include(s=>s.Documents).Load();

            studentsGridView.ItemsSource = _dataBase.Students.Local.ToBindingList();
           
            
        }

        protected void InitialData(HostelContext context)
        {
            Group g1 = new Group();
            g1.Faculty = "ФВС";
            g1.Num = "515-2";

            Group g2 = new Group();
            g1.Faculty = "ФБ";
            g1.Num = "432";

            context.Groups.Add(g1);
            context.Groups.Add(g2);
            context.SaveChanges();

            Student s1 = new Student();
            s1.Name = "Андрей";
            s1.Room = 211;
            s1.Sex = Sex.Male;
            s1.Group = context.Groups.FirstOrDefault(g => g.Num == "515-2");
            s1.PhoneNumber = "8999123456";

            context.Students.Add(s1);
            context.SaveChanges();

            Student s2 = new Student();
            s2.Name = "Василий";
            s2.Room = 561;
            s2.Sex = Sex.Male;
            s2.Group = context.Groups.FirstOrDefault(g => g.Num == "432");
            s2.PhoneNumber = "8777981231";

            context.Students.Add(s2);
            context.SaveChanges();

            Department department = new Department();
            department.Name = "Санитарная комиссия";

            context.Departments.Add(department);
            context.SaveChanges();

            Applicant applicant = new Applicant();
            applicant.Name = "Иванов А.Г.";
            applicant.Department = context.Departments.FirstOrDefault();

            context.Applicants.Add(applicant);
            context.SaveChanges();

            PromotionDocument document = new PromotionDocument();
            document.Comments = "Поощрение";
            document.DocumentDate = DateTime.Now;
            document.Name = "Поощренеие ";
            document.Points = 5;
            document.Applicant = applicant;
            document.Students = new List<Student>();
            document.Students.Add(s1);
            document.Students.Add(s2);

            context.Documents.Add(document);
            context.SaveChanges();

            context.Groups.Load();
            var doc = context.Documents.Include(d=>d.Students).Include(d=>d.Applicant).Include(d=>d.Applicant.Department).FirstOrDefault();


        }
    }
}
