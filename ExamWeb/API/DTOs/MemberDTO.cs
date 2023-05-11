namespace API.DTOs
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePhotoURL { get; set; }
        public List<ExamDTO> Exams { get; set; } = new List<ExamDTO>();
    }
}