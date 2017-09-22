using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HostelData.Model.Document;
using HostelData.Model.Enums;
using HostelData.Model.Student;

namespace ClHsWinFormsApp
{
    public partial class AddPunishmentDocumentForm : Form
    {
        private List<Student> _students;
        private List<Applicant> _applicants;

        private PunishmentDocument _document;

        public AddPunishmentDocumentForm(List<Student> students, List<Applicant> applicants)
        {
            InitializeComponent();

            _students = students;
            _applicants = applicants;

            _document = new PunishmentDocument()
                        {
                            Students = new List<Student>()
                        };
            studentsGridViewBindingSource.DataSource = _document.Students;

            addStudentBindingSource.DataSource = _students;

            applicantBindingSource.DataSource = _applicants;

            DialogResult= DialogResult.Cancel;
        }

        public PunishmentDocument PunishmentDocument => _document;

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            studentsGridViewBindingSource.Add(addStudentBindingSource.Current);
        }

        private void addByRoomButton_Click(object sender, EventArgs e)
        {
            foreach (Student student in _students.Where(s => s.Room == ((Student)addStudentBindingSource.Current).Room))
            {
                studentsGridViewBindingSource.Add(student);
            }
        }

        private void removeSelectedStudent_Click(object sender, EventArgs e)
        {
            studentsGridViewBindingSource.RemoveCurrent();
        }

        private void addStudentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var student = ((Student)addStudentBindingSource.Current);
            if (student != null)
            {
                selectedStudentGroup.Text = student.Group != null ? student.Group.Num : "-";
                selectedStudentRoom.Text = student.Room.ToString();
            }
        }

        private void addPunishmentButton_Click(object sender, EventArgs e)
        {
            _document.Points = -1* Convert.ToInt32(pointsTextBox.Text);
            _document.Verdict = (Verdict)verdictComboBox.SelectedIndex;
            _document.Applicant = (Applicant)applicantBindingSource.Current;
            _document.Comments = commentsTextBox.Text;
            _document.DocumentDate = documentDatePicker.Value;
            DialogResult = DialogResult.OK;
        }


    }
}
