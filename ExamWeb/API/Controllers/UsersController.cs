using System.Security.Claims;
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

        [HttpPut("{username}/edit")]
        public async Task<ActionResult> UpdateUser(string username, MemberUpdateDTO memberUpdateDTO)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null) return NotFound();
            _mapper.Map(memberUpdateDTO, user);
            if (await _userRepository.SaveAllASync()) return NoContent();
            return BadRequest("Failed to update user!");
        }
    }
}