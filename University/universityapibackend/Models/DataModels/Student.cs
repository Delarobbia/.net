using Microsoft.Build.Framework;

namespace Universityapibackend.Models.DataModels
{
    public class Student: BaseEntity
    {
        [Required]
        public string Name { get; set; }= string.Empty;
        [Required]
        public string LasName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }

        public ICollection<Curso> Cursos { get; set; }= new List<Curso>();
    }
}
