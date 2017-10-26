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
    public partial class StudentCardForm : Form
    {
        private Student _student;

        public StudentCardForm(Student student)
        {
            InitializeComponent();

            nameTextBox.Text = student.Name;
            phoneTextBox.Text = student.PhoneNumber;
            //TODO:Проверка на null
            groupTextBox.Text = student.Group.Num;
            roomTextBox.Text = student.Room.ToString();
            pointsLabel.Text = student.Points.ToString();
            //TODO: Не грузятся поощьрения
            baseDocumentBindingSource.DataSource = student.Documents;
            //TODO: 2 раза тыкать по документам

        }

        public Student Student
        {
            get
            {

                return _student;
            }
        }
    }
}
