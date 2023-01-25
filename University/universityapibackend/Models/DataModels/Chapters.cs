namespace Universityapibackend.Models.DataModels
{
    public class Chapters : BaseEntity
    {
        public int Numerotemas { get; set; }
        public string Tema1 { get; set; }
        public int CourseId { get; set; }
        public virtual Curso Course { get; set; } = new Curso();
    
    }
}
