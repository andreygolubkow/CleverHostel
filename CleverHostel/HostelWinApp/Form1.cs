using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HostelData.DataBase;
using HostelData.Model.Student;

namespace HostelWinApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HostelContext db = new HostelContext())
            {
                Group g = new Group()
                          {
                              Faculty = "FVS",
                              Num = "515-2"
                          };
                MessageBox.Show(Convert.ToString(g.Course));
                db.Groups.Add(g);
                db.SaveChanges();

                var Gr = db.Groups.FirstOrDefault();
                MessageBox.Show(Convert.ToString(Gr.Course));
            }
        }
    }
}
