using System;
using System.Collections.Generic;
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

namespace ClHsWinFormsApp
{
    public partial class MainForm : Form
    {
        private HostelContext _hostelContext;

        public MainForm()
        {
            InitializeComponent();
            _hostelContext = new HostelContext(Properties.Settings.Default.ConnectionString);
            studentBindingSource.DataSource = _hostelContext.Students.Local.ToBindingList();
            _hostelContext.Students.LoadAsync();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
