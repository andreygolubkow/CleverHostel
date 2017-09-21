using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HostelData.DataBase;
using HostelData.Model.Student;
using HostelData.Tools;

namespace ClHsWinFormsApp
{
    public partial class MainForm : Form
    {
        private HostelContext _hostelContext;
        
        public MainForm()
        {
            InitializeComponent();
            
            _hostelContext = new HostelContext(Properties.Settings.Default.ConnectionString);
            studentBindingSource.DataSource = _hostelContext.Students.Include(s => s.Group).ToList();
            findStudentTextBox.AutoCompleteCustomSource.AddRange(_hostelContext.Students.Select(s=>s.Name).ToArray());

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FindStudentTextBoxTextChanged(object sender, EventArgs e)
        {
            if ( findStudentTextBox.TextLength > 0 )
            {
                var text = findStudentTextBox.Text;
                var list = _hostelContext.Students.Include(s => s.Group)
                        .Where(s => s.Name.ToLower().Contains(text.ToLower()))
                        .ToList();
                studentBindingSource.DataSource = list; 
            }
            else
            {
                studentBindingSource.DataSource = _hostelContext.Students.Include(s=>s.Group).ToList();
            }

        }

        private void importStudentsMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ImportStudentsForm(_hostelContext);
            form.ShowDialog();
        }
    }
}
