using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HostelData.Model.Student;

namespace ClHsWinFormsApp
{
    public partial class AddApplicantForm : Form
    {
        private List<Department> _departments;

        public AddApplicantForm(List<Department> departments)
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
            _departments = departments;
            departmentComboBox.Items.Clear();
            foreach (var department in _departments)
            {
                departmentComboBox.Items.Add(department);
            }
        }

        public Applicant Applicant
        {
            get
            {
                return new Applicant()
                       {
                           Name = nameTextBox.Text,
                           Department = _departments.FirstOrDefault(d => d.Name == departmentComboBox.Text) != null
                               ? _departments.FirstOrDefault(d => d.Name == departmentComboBox.Text)
                               : new Department()
                                 {
                                     Name = departmentComboBox.Text
                                 }
                       };
            }
        }

        private void addApplicantButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void AddApplicantForm_Load(object sender, EventArgs e)
        {

        }
    }
}
