using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Exams")]
    public class Exam
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        public string ProfessorName { get; set; }
        public float ExamGrade { get; set; }
        public List<Subject> Subjects { get; set; } = new ();

        // Relation Data
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}