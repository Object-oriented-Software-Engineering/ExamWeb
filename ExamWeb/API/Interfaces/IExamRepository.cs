using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IExamRepository
    {
        void Update(Exam exam);
        Task<bool> SaveAllASync();
        Task<IEnumerable<ExamDTO>> GetExamsAsync(string username);
        Task<ExamDTO> GetExamAsync(string username, int id);
    }
}