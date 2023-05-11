using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class ExamsController : BaseAPIController
    {
        private readonly IExamRepository _examRepository;
        public IMapper _mapper { get; }
        public ExamsController(IExamRepository examRepository, IMapper mapper)
        {
            _mapper = mapper;
            _examRepository = examRepository;
        }

        [HttpGet("{username}/")]
        public async Task<ActionResult<IEnumerable<ExamDTO>>> GetExams(string username)
        {
            var exams = await _examRepository.GetExamsAsync(username);
            return Ok(exams);
        }

        [HttpGet("{username}/{id}/")]
        public async Task<ActionResult<ExamDTO>> GetExam(string username, int id)
        {
            return await _examRepository.GetExamAsync(username, id);
        }
    }
}