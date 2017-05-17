using Core.Model.Documents;

using Microsoft.EntityFrameworkCore;

namespace Core.DataBase
{
    public class DocumentContext : DbContext
    {
        public DbSet<IDocument> Documents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hostelData;Trusted_Connection=True;");
        }

    }
}
