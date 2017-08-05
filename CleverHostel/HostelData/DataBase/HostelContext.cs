// //CleverHostel->HostelData->HostelContext.cs
// //andreygolubkow Андрей Голубков

using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

using HostelData.Annotations;
using HostelData.Model.Document;
using HostelData.Model.Student;

namespace HostelData.DataBase
{
    public class HostelContext : DbContext
    {

        public DbSet<Group> Groups { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        
        public DbSet<Applicant> Applicants { get; set; }

        public DbSet<BaseDocument> Documents { get; set; }


        public HostelContext(string connectionString)
            :base(connectionString)
        { }


    }
}
