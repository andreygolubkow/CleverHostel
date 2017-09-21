using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClHsWinFormsApp.Properties;

namespace ClHsWinFormsApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            dataBaseTextBox.Text = Settings.Default.ConnectionString;
        }

        private void selectDataBasePath_Click(object sender, EventArgs e)
        {
            if ( dataBaseFolderBrowserDialog.ShowDialog() == DialogResult.OK )
            {
                string connectionString =
                        "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=;Integrated Security=True";
                Settings.Default.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+ dataBaseFolderBrowserDialog.SelectedPath + "\\HostelData.base"+";Integrated Security=True";
                dataBaseTextBox.Text = Settings.Default.ConnectionString;
                Settings.Default.Save();
            }
        }

        private void saveConnectionStringButton_Click(object sender, EventArgs e)
        {
            Settings.Default.ConnectionString = dataBaseTextBox.Text;
            Settings.Default.Save();
        }
    }
}
