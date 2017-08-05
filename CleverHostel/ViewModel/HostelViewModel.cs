using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HostelData.DataBase;
using HostelData.Model.Student;

namespace ViewModel
{
    public class HostelViewModel : IDisposable
    {
        private HostelContext _hostelContext;

        private Student _selectedStudent;



        public HostelViewModel(string dataBaseConntectionString)
        {
            _hostelContext = new HostelContext(dataBaseConntectionString);
        }

        public ObservableCollection<Student> Students
        {
            get
            {
                var studentsList = _hostelContext.Students.ToList();
                _hostelContext.Groups.Load();
                _hostelContext.Departments.Load();
                _hostelContext.Applicants.Load();
                _hostelContext.Documents.Load();

                return new ObservableCollection<Student>(studentsList);
            }
        }
        



        #region IDisposable

        /// <inheritdoc />
        public void Dispose()
        {
            _hostelContext.Dispose();
        }

        #endregion
    }
}
