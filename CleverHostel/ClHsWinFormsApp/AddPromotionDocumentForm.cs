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

            _document = new PromotionDocument();
            _document.Students = new List<Student>();
            studentsGridViewBindingSource.DataSource = _document.Students;

            addStudentBindingSource.DataSource = _students;

            applicantBindingSource.DataSource = _applicants;
        }


    }
}
