using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCHAT.API.Dtos;
using PCHAT.Domain.Entities;
using PCHAT.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PCHAT.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly IAuthRepository _authrepository;
        public AuthController(IUnitOfWork unitofwork, IAuthRepository authrepo)
        {
            _unitofwork = unitofwork;
            _authrepository = authrepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDto userregisterdto)
        {
            //validate request
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!string.IsNullOrEmpty(userregisterdto.UserName))
                userregisterdto.UserName = userregisterdto.UserName.ToLower();

            if (await _authrepository.UserExists(userregisterdto.UserName))
                return BadRequest("username already taken, Try a different username");


            var usertocreate = JObject.FromObject(userregisterdto, new JsonSerializer { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }).ToObject<User>();

            try
            {
                var createduser = await _authrepository.Register(usertocreate, userregisterdto.Password);

                return Ok($"User {createduser.UserName} successfully created!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userlogindto)
        {
            var userFromRepo = await _authrepository.Login(userlogindto.Username.ToLower(), userlogindto.Password);
            if (userFromRepo == null)
                return BadRequest("Login failed, username or password incorrect");

            //generate token
            var token = GenerateToken(userFromRepo);

            try
            {
                var user = JObject.FromObject(userFromRepo, new JsonSerializer { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }).ToObject<UserDto>();
                return Ok(new { message = "Login was successful", UserName = user.UserName, Gender = user.Gender, Id = user.Id, token });

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        private string GenerateToken(User userFromRepo)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("super secret key");
            var tokendescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                        new Claim(ClaimTypes.Name, userFromRepo.UserName)

                }),
                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)

            };
            var token = tokenhandler.CreateToken(tokendescriptor);
            var tokenString = tokenhandler.WriteToken(token);
            return tokenString;
        }
    }
}
