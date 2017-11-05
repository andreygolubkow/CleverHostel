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

        public DbSet<Document> Documents { get; set; }



        public HostelContext()
            : base()
        { }

        public HostelContext(string connectionString)
            :base(connectionString)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<PromotionDocument>()
                    .Map(m =>
                    {
                        m.MapInheritedProperties();
                        m.ToTable("Promotions");
                    });
            modelBuilder.Entity<PunishmentDocument>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Punishments");
            });
            modelBuilder.Entity<OtherDocument>()
                    .Map(m =>
                    {
                        m.MapInheritedProperties();
                        m.ToTable("OtherDocs");
                    });
            */
        }


    }
}
