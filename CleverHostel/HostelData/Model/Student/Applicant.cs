using System.ComponentModel;
using System.Runtime.CompilerServices;

using HostelData.Annotations;

namespace HostelData.Model.Student
{
    public class Applicant : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private Department _department;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
                OnPropertyChanged(nameof(Department));
            }
        }

        #region Overrides of Object

        /// <inheritdoc />
        public override string ToString()
        {
            return Name;
        }

        #endregion

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
