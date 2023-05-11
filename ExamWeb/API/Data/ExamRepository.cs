using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ExamRepository : IExamRepository
    {
        private readonly DataContext _context;
        public IMapper _mapper { get; }
        public ExamRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public void Update(Exam exam)
        {
            _context.Entry(exam).State = EntityState.Modified;
        }

        public async Task<bool> SaveAllASync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<ExamDTO>> GetExamsAsync(string username)
        {
            return await _context.Exams.Where(x => x.AppUser.UserName == username).ProjectTo<ExamDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<ExamDTO> GetExamAsync(string username, int id)
        {
            return await _context.Exams.Where(x => x.Id == id).ProjectTo<ExamDTO>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }
    }
}