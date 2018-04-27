using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

using Microsoft.Win32;

using WpfAutoCompleteControls.Editors;

namespace ArrearsChecker
{
    public class MainVM : INotifyPropertyChanged, ISuggestionProvider
    {
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public event PropertyChangedEventHandler PropertyChanged;



        public MainVM()
        {
            Students = StudentsImporter.ReadStudents("students.tsv");
        }

        
        public ObservableCollection<Student> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged("Students");
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Implementation of ISuggestionProvider

        /// <inheritdoc />
        public IEnumerable GetSuggestions(string filter)
        {
            return _students.Where(s => s.Name.ToLower().Contains(filter.ToLower()));
        }

        #endregion
    }
}
