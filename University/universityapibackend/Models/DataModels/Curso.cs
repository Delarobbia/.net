using System.ComponentModel.DataAnnotations;

namespace Universityapibackend.Models.DataModels
{

    public enum Nivel {
        Basico, 
        Intermedio, 
        Avanzado 
    }
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string Descripcion_corta { get; set; }

        public string Descripcion_larga { get; set; }

        public string Publico_objetivo { get; set; }

        public string Objetivos { get; set; }

        public string Requisitos { get; set; }
        public Nivel Nivel { get; set; } = Nivel.Basico;

        [Required]
        public ICollection<Category> Categories { get; set; }=new List<Category>();

        [Required]
        public Chapters Index { get; set; } = new Chapters();
        [Required]
        public ICollection<Student> Students { get; set; }= new List<Student>();
        
    }
}
