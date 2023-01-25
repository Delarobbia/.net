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
        public DbSet<Curso>? Curso { get; set; }
    
    }

    

}
