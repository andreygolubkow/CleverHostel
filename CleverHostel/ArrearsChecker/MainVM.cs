using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

using WpfAutoCompleteControls.Editors;

namespace ArrearsChecker
{
    public class MainVM : INotifyPropertyChanged, ISuggestionProvider
    {
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public event PropertyChangedEventHandler PropertyChanged;

        private string _selectedText = "";
        private Student _selectedStudent = null;


        public MainVM()
        {
            _students.Add(new Student()
                          {
                                  Active = true,
                                  Arrear = 10,
                                  Group = "515-2",
                                  Name = "Иванов Петр",
                                  PayDays = new List<DateTime>()
                                            {
                                                    new DateTime(2018,1,12)
                                            }
                          });
            _students.Add(new Student()
                          {
                                  Active = true,
                                  Arrear = 10,
                                  Group = "515-2",
                                  Name = "Молчанов Константин"
                          });
            _students.Add(new Student()
                          {
                                  Active = true,
                                  Arrear = 10,
                                  Group = "515-2",
                                  Name = "Михайлов Влад"
                          });
            _students.Add(new Student()
                          {
                                  Active = true,
                                  Arrear = 10,
                                  Group = "515-2",
                                  Name = "Иголкин Иван"
                          });
        }

        public string SelectedText
        {
            set
            {
                if ( value.Length == 0 )
                {
                    return;
                }
                _selectedStudent = _students.FirstOrDefault(s=>s.Name.StartsWith(value));
                _selectedText = value;
                OnPropertyChanged("SelectedText");
                OnPropertyChanged("SelectedStudent");
            }
            get => _selectedText;
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                if ( value == null )
                {
                    return;
                }
                _selectedStudent = value;
                _selectedText = value.Name;
                OnPropertyChanged("SelectedStudent");
                OnPropertyChanged("SelectedText");
            }
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

            if (string.IsNullOrWhiteSpace(filter))
            {
                return _students;
            }

            filter = filter.Trim();
            return _students
                    .Where(x => x.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        #endregion
    }
}
