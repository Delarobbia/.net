using System.ComponentModel.DataAnnotations;

namespace Universityapibackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        [StringLength(280)]
        public string Descripcion_corta { get; set; }

        public string Descripcion_larga { get; set; }

        public string Publico_objetivo { get; set; }

        public string Objetivos { get; set; }

        public string Requisitos { get; set; }

        public enum Nivel {Basico,Intermedio,Avanzado }
        
    }
}
