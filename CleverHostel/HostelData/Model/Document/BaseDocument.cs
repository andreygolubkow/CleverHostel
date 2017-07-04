// //CleverHostel->HostelData->IDocument.cs
// //andreygolubkow Андрей Голубков

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

using HostelData.Annotations;
using HostelData.Model.Student;

namespace HostelData.Model.Document
{
    /// <summary>
    /// Интерфейс документа.
    /// </summary>
    public class BaseDocument: INotifyPropertyChanged
    {
        private int _id;
        private DateTime _documentDate;
        private string _comments;
        private Applicant _applicant;
        private List<Student.Student> _students;
        private int _points;

        public event PropertyChangedEventHandler PropertyChanged;

        protected BaseDocument()
        {
        }

        /// <summary>
        /// Уникальный идентификатор документа.
        /// </summary>
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

        /// <summary>
        /// Дата документа.
        /// </summary>
        public DateTime DocumentDate
        {
            get
            {
                return _documentDate;
            }
            set
            {
                _documentDate = value;
                OnPropertyChanged(nameof(DocumentDate));
            }
        }

        /// <summary>
        /// Очки начисляемые или снимаемые.
        /// </summary>
        public virtual int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
                OnPropertyChanged(nameof(Points));
            }
        }

        /// <summary>
        /// Комментарии к документу.
        /// </summary>
        public string Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                _comments = value;
                OnPropertyChanged(nameof(Comments));
            }
        }

        /// <summary>
        /// Заявитель
        /// </summary>
        public Applicant Applicant
        {
            get
            {
                return _applicant;
            }
            set
            {
                _applicant = value;
                OnPropertyChanged(nameof(Applicant));
            }
        }

        public virtual List<Student.Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}