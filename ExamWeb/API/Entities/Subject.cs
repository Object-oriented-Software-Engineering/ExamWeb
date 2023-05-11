using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Subjects")]
    public class Subject
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Wording { get; set; }

        // User Input
        public string Answer { get; set; }

        // Professor Input.
        public float SubjectGrade { get; set; }

        // Relation Data
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}