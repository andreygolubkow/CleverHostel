using System.Windows;

using HostelData.DataBase;

using Microsoft.Win32;

namespace HostelWpfApp
{
    /// <summary>
    /// Логика взаимодействия для DataHandlerForm.xaml
    /// </summary>
    public partial class DataHandlerForm : Window
    {
        public DataHandlerForm(HostelContext dataBasContext)
        {
            InitializeComponent();
        }

        private void SelectFileButtonClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
                                            {
                                                Title = "Выберите файл для импорта",
                                                Multiselect = false,
                                                CheckFileExists = true,
                                                CheckPathExists = true,
                                                DefaultExt = "CSV файл|*.csv",
                                                Filter = "CSV файл|*.csv"
                                            };
            if ( openFileDialog.ShowDialog() == true )
            {
                FileNameTextBox.Text = openFileDialog.FileName;
            }

        }
    }
}
