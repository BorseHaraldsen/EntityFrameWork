using ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp.DataAccess.SqLite
{
    public class SchoolDbContext : DbContext
    {

        public DbSet<Student> Student => Set<Student>(); /*{ get; set; } Could use a getter setter. */ 
        // This will be the name of your database. Either pluar or singular.

        public DbSet<Education> Education => Set<Education>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Resourcers\School.db"); 
            // @ to read each character as is, so you dont have to new line etc on backslashes
        }

    }
}
