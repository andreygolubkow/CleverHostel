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
using HostelData.Model.Student;

namespace ClHsWinFormsApp
{
    public partial class AddPromotionDocumentForm : Form
    {
        private List<Student> _students;

        private List<Applicant> _applicants;

        private PromotionDocument _document;

        public AddPromotionDocumentForm(List<Student> students, List<Applicant> applicants)
        {
            InitializeComponent();

            _students = students;
            _applicants = applicants;

            _document = new PromotionDocument
                        {
                            Students = new List<Student>()
                        };
            studentsGridViewBindingSource.DataSource = _document.Students;

            addStudentBindingSource.DataSource = _students;

            applicantBindingSource.DataSource = _applicants;
            DialogResult = DialogResult.Cancel;
        }

        [DefaultValue(null, "Empty")]
        public PromotionDocument PromotionDocument => _document;

        private void addStudentComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

            
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            studentsGridViewBindingSource.Add(addStudentBindingSource.Current);
        }

        private void addByRoomButton_Click(object sender, EventArgs e)
        {
            foreach (Student student in _students.Where(s=>s.Room == ((Student)addStudentBindingSource.Current).Room))
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

        private void addPromotionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _document.Name = nameTextBox.Text;
            _document.Points = Convert.ToInt32(pointsTextBox.Text);
            _document.Comments = commentsTextBox.Text;
            _document.DocumentDate = datePicker.Value;
            _document.Applicant = (Applicant)applicantBindingSource.Current;

        }
    }
}
