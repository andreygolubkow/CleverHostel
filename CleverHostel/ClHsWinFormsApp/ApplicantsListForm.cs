using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

using HostelData.DataBase;
using HostelData.Model.Student;

namespace ClHsWinFormsApp
{
    public partial class ApplicantsListForm : Form
    {
        private HostelContext _hostelContext;

        public ApplicantsListForm(HostelContext hostelContext)
        {
            InitializeComponent();
            _hostelContext = hostelContext;

            LoadData();
            
        }

        public void LoadData()
        {
            _hostelContext.Departments.Load();
            applicantBindingSource.DataSource = _hostelContext.Applicants.ToList();
        }

        private void removeMenuItem_Click(object sender, System.EventArgs e)
        {
            if ( applicantBindingSource.Current != null )
            {
                Applicant applicant = (Applicant)applicantBindingSource.Current;
                _hostelContext.Applicants.Remove(applicant);
                applicantBindingSource.RemoveCurrent();
                _hostelContext.SaveChanges();
            }
        }

        private void addMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new AddApplicantForm(_hostelContext.Departments.ToList());
            if ( form.ShowDialog() == DialogResult.OK )
            {
                _hostelContext.Applicants.Add(form.Applicant);
                _hostelContext.SaveChanges();
                LoadData();
            }
        }

        private void nameFilterTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (nameFilterTextBox.TextLength > 0)
            {
                var text = nameFilterTextBox.Text;
                var list = _hostelContext.Applicants.Where(a => a.Name.Contains(text.ToLower())).ToList();
                applicantBindingSource.DataSource = list;
            }
            else
            {
                applicantBindingSource.DataSource = _hostelContext.Applicants.ToList();
            }
        }

        private void departmentFilterTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (departmentFilterTextBox.TextLength > 0)
            {
                var text = departmentFilterTextBox.Text;
                var list = _hostelContext.Applicants.Include(a=>a.Department).Where(a => a.Department.Name.Contains(text.ToLower())).ToList();
                applicantBindingSource.DataSource = list;
            }
            else
            {
                applicantBindingSource.DataSource = _hostelContext.Applicants.ToList();
            }
        }
    }
}
