using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllASync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDTO>> GetMembersAsync();

        // Role Based
        Task<IEnumerable<MemberDTO>> GetStudentsAsync();
        Task<IEnumerable<MemberDTO>> GetProfessorsAsync();
        Task<MemberDTO> GetStudentAsync(string username);
        Task<MemberDTO> GetProfessorAsync(string username);
    }
}