namespace Core.DataBase
{
    using System;
    using System.Data.Entity;

    using Core.Model.Student;

    public class StudentContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentContext"/> class.
        /// </summary>
        public StudentContext()
            : base("DbConnection")
        {
            
        }

        public DbSet<Student> Students { get; set; }
        
    }
}