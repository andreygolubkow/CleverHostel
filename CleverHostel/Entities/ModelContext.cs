// //CleverHostel->Entities->ModelContext.cs
// //andreygolubkow Андрей Голубков

using Entities.Model;

using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ModelContext:DbContext
    {
        public DbSet<IDocument> Documents { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=HostelData.data");
        }
    }
}
