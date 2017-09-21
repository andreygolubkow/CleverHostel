using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

using HostelData.DataBase;
using HostelData.Model.Student;
using HostelData.Tools;

namespace ClHsWinFormsApp
{
    public partial class ImportStudentsForm : Form
    {
        private HostelContext _hostelContext; 

        public ImportStudentsForm(HostelContext hostelContext)
        {
            InitializeComponent();
            _hostelContext = hostelContext;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            var importer = new CsvStudentsImporter(sourceFileTextBox.Text,delimitterTextBox.Text[0],maleTextBox.Text,femaleTextBox.Text);
            var list = importer.ImportStudents(skipFirstString.Checked);
            foreach (var student in list)
            {
                var group = _hostelContext.Groups.FirstOrDefault(g => g.Num == student.Group.Num);
                if ( group != null )
                {
                    student.Group = group;
                }
                else
                {
                    var g = new Group();
                    g.Num = student.Group.Num;
                    _hostelContext.Groups.Add(g);
                    _hostelContext.SaveChanges();
                    student.Group = g;
                }
                _hostelContext.Students.Add(student);
                _hostelContext.SaveChanges();
            }


        }

        private void selectSourceButton_Click(object sender, EventArgs e)
        {
            if ( openFileDialog.ShowDialog() == DialogResult.OK )
            {
                sourceFileTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}
