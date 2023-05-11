using System.Collections.Generic;

namespace API.DTOs
{
    public class ExamDTO
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        public string ProfessorName { get; set; }
        public float ExamGrade { get; set; }
        public List<SubjectDTO> Subjects { get; set; } = new List<SubjectDTO>();
    }
}