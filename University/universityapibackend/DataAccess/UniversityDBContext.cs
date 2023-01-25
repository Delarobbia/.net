using Microsoft.EntityFrameworkCore;
using Universityapibackend.Models.DataModels;

namespace Universityapibackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }
   
        //TODO: Add DbSets (Tables of our Data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Chapters>? Chapters { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
    }

    

}
