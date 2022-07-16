using Microsoft.EntityFrameworkCore;
namespace E_learning_App.Models
{
    public class E_LearningContext : DbContext
    {
        public DbSet<Student>? students { get; set; }

        public DbSet<Instructor>? Insstructor { get; set; }
        public DbSet<Course>? Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=E-Learning-App;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
