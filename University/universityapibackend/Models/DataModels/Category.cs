using System.ComponentModel.DataAnnotations;

namespace Universityapibackend.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
