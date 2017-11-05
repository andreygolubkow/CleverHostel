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
    public partial class StudentCardForm : Form
    {
        private Student _student;

        /// <inheritdoc />
        /// <summary>
        /// Создаст форму, и отобразит данные готового студента.
        /// </summary>
        /// <param name="student"></param>
        public StudentCardForm(Student student)
        {
            InitializeComponent();

            nameTextBox.Text = student.Name;
            phoneTextBox.Text = student.PhoneNumber;
            if ( student.Sex == Sex.Female )
            {
                fRadioButton.Checked = true;
            }
            else
            {
                mRadioButton.Checked = true;
            }
            
            if ( student.Group != null )
            {
               groupTextBox.Text = student.Group.Num; 
            }
            isActiveStudent.Checked = student.Active;
            roomTextBox.Text = student.Room.ToString();
            pointsLabel.Text = student.Points.ToString();

            documentBindingSource.DataSource = student.Documents.ToList();
            _student = student;
        }

        /// <inheritdoc />
        /// <summary>
        /// Создаст пустую форму.
        /// </summary>
        public StudentCardForm()
        {
            InitializeComponent();

            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            groupTextBox.Text = "";

            isActiveStudent.Checked = true;
            roomTextBox.Text = "";
            pointsLabel.Text =@"0";
            documentBindingSource.DataSource = new List<Document>();
            _student = new Student
                       {
                           Group = new Group()
                       };
        }

        public Student Student => _student;

        private void saveButton_Click(object sender, EventArgs e)
        {
            _student.Name = nameTextBox.Text;
            _student.PhoneNumber = phoneTextBox.Text;
            _student.Sex = mRadioButton.Checked ? Sex.Male : Sex.Female;
            if ( _student?.Group.Num != groupTextBox.Text )
            {
                _student.Group = new Group()
                             {
                                 Num = groupTextBox.Text
                             };
            }
            _student.Active = isActiveStudent.Checked;
            _student.Room = Convert.ToInt32(roomTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void docementsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var document = ((Document)documentBindingSource.Current);

            if ( document is PromotionDocument p)
            {
                MessageBox.Show("Название:"+p.Name + "\nЗаявитель:"+p.Applicant+ "\tПодразделение:" + p.Applicant.Department+"\nКомментарий:" +p.Comments);
                return;
            }

            if (document is PunishmentDocument ps)
            {
                MessageBox.Show("Вердикт:"+ps.Verdict+"\nЗаявитель"+ps.Applicant+"\tПодразделение:"+ps.Applicant.Department+"\nКомментарий:"+ps.Comments);
                return;
            }


        }
    }
}
