using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseAPIController
    {
        private readonly IUserRepository _userRepository;
        public IMapper _mapper { get; }
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();
            return Ok(users);
        }

        // Role Based
        [HttpGet("students/")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetStudents()
        {
            var users = await _userRepository.GetStudentsAsync();
            return Ok(users);
        }

        [HttpGet("professors/")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetProfessors()
        {
            var users = await _userRepository.GetProfessorsAsync();
            return Ok(users);
        }

        [HttpGet("student/{username}/")]
        public async Task<ActionResult<MemberDTO>> GetStudent(string username)
        {
            return await _userRepository.GetStudentAsync(username);
        }

        [HttpGet("professor/{username}/")]
        public async Task<ActionResult<MemberDTO>> GetProfessor(string username)
        {
            return await _userRepository.GetProfessorAsync(username);
        }
    }
}