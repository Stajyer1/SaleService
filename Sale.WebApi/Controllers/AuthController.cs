using Business.Abstract;
using Entities.DTOs;
using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IUserService _service;
        public AuthController(IAuthService authService,IUserService service)
        {
            _authService = authService;
            _service = service;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            var person = _service.GetByMail(userForLoginDto.Email);
            
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                UserDetailDto detail = new UserDetailDto() { result = result, user = person };
                return Ok(detail);
                
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var person = _service.GetByMail(registerResult.Data.Email);
            
            var result = _authService.CreateAccessToken(registerResult.Data);
            UserDetailDto detail = new UserDetailDto() { result = result, user = person };
            if (result.Success)
            {
                return Ok(detail);
            }

            return BadRequest(result.Message);
        }
    }
}