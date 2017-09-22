using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

using HostelData.DataBase;

namespace ClHsWinFormsApp
{
    public partial class MainForm : Form
    {
        private HostelContext _hostelContext;
        
        public MainForm()
        {
            InitializeComponent();
            
            LoadData();
        }

        private void LoadData()
        {
            _hostelContext = new HostelContext(Properties.Settings.Default.ConnectionString);
            _hostelContext.Database.CreateIfNotExists();
            studentBindingSource.DataSource = _hostelContext.Students.Include(s => s.Group).ToList();
            findStudentTextBox.AutoCompleteCustomSource.Clear();
            findStudentTextBox.AutoCompleteCustomSource.AddRange(_hostelContext.Students.Select(s => s.Name).ToArray());

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

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            LoadData();

        }

        private void addPromotionManuItem_Click(object sender, EventArgs e)
        {
            var promotionForm = new AddPromotionDocumentForm(_hostelContext.Students.Include(s=>s.Group).ToList(),_hostelContext.Applicants.ToList());
            if ( promotionForm.ShowDialog() == DialogResult.OK )
            {
                _hostelContext.Documents.Add(promotionForm.PromotionDocument);
                _hostelContext.SaveChanges();
            }
        }

        private void addPunishmentMenuItem_Click(object sender, EventArgs e)
        {
            var punishmentForm = new AddPunishmentDocumentForm(_hostelContext.Students.Include(s => s.Group).ToList(), _hostelContext.Applicants.ToList());
            if (punishmentForm.ShowDialog() == DialogResult.OK)
            {
                _hostelContext.Documents.Add(punishmentForm.PunishmentDocument);
                _hostelContext.SaveChanges();
            }
        }
    }
}
