namespace API.DTOs
{
    public class SubjectDTO
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Wording { get; set; }

        // User Input
        public string Answer { get; set; }

        // Professor Input.
        public float SubjectGrade { get; set; }
    }
}