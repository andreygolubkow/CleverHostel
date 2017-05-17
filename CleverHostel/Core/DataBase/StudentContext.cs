namespace Core.DataBase
{
    using Microsoft.EntityFrameworkCore;
    using Model.Student;

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hostelData;Trusted_Connection=True;");
        }

    }
}