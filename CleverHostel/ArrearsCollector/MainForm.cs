using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ArrearsChecker;

namespace ArrearsCollector
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private ArrearsCsvImporter importer = new ArrearsCsvImporter();

        private List<Student> arrears = new List<Student>();
        private List<Student> unknowns = new List<Student>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void selectPvzButton_Click(object sender, EventArgs e)
        {
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                students.AddRange(importer.ReadPvzData(openFileDialog.FileName));
                logTextBox.Text += "\nЗагружен файл ПВЗ.";
            }
        }

        private void selectBugdetFileButton_Click(object sender, EventArgs e)
        {
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                students.AddRange(importer.ReadBudgetData(openFileDialog.FileName));
                logTextBox.Text += "\nЗагружен файл бюджетников.";
            }
        }

        private void selectHostelFileButton_Click(object sender, EventArgs e)
        {
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                CollectStudents(importer.ReadHostelData(openFileDialog.FileName));
            }
        }

        private void CollectStudents(List<Student> hostelDataList)
        {
            logTextBox.Text += "\nНачинаем сборку списков.";
            foreach (Student student in students)
            {
                Student hostelData = hostelDataList.FirstOrDefault(s => s.Name.Contains(student.Name) || student.Name.Contains(s.Name));
                if ( hostelData != null )
                {
                    student.Room = hostelData.Room;
                    student.Group = hostelData.Group;
                    arrears.Add(student);
                }
                else
                {
                    logTextBox.Text += "\nСтудент не найден:"+student.Name;
                    unknowns.Add(student);
                }
            }
            logTextBox.Text += @"\nКонец сборки списков.\n";
        }

        private void saveArrearsFileButton_Click(object sender, EventArgs e)
        {
            StringBuilder csv = new StringBuilder();
            foreach (Student student in arrears)
            {
                csv.Append(student.Name);
                csv.Append("\t");
                csv.Append(student.Room);
                csv.Append("\t");
                csv.Append(student.Arrear);
                csv.Append("\t");
                csv.Append(student.Group);
                csv.Append("\t");
                csv.Append(student.Active);
                csv.Append("\t");
                csv.Append(student.EducationForm);
                csv.Append("\n");
            }

            if ( saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName,false))
                {
                    writer.Write(csv);
                }
            }
        }

        private void saveUnknownFileButton_Click(object sender, EventArgs e)
        {
            StringBuilder csv = new StringBuilder();
            foreach (Student student in unknowns)
            {
                csv.Append(student.Name);
                csv.Append("\t");
                csv.Append(student.Room);
                csv.Append("\t");
                csv.Append(student.Arrear);
                csv.Append("\t");
                csv.Append(student.Group);
                csv.Append("\t");
                csv.Append(student.Active);
                csv.Append("\t");
                csv.Append(student.EducationForm);
                csv.Append("\n");
            }

            if ( saveFileDialog.ShowDialog() == DialogResult.OK )
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName,false))
                {
                    writer.Write(csv);
                }
            }
        }
    }
}
