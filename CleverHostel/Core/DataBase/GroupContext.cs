

using Core.Model.Student;

using Microsoft.EntityFrameworkCore;

namespace Core.DataBase
{
    public class GroupContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hostelData;Trusted_Connection=True;");
        }
    }
}
