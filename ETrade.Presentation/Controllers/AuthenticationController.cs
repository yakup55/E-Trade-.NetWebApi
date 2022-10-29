using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    [ApiController]
    [Route("api/authentications")]
    [Authorize]
    public class AuthenticationController:ControllerBase
    {
        private readonly IAuthenticationService service;

        public AuthenticationController(IAuthenticationService service)
        {
            this.service = service;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDtoRegistraction registraction)
        {
            var result = service.RegisterResult(registraction);
            //if (!result)
            //{

            //}
            return StatusCode(201);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody]UserDtoAuthentication authentication)
        {
            if (!await service.ValidateUser(authentication))
                return Unauthorized();

            var detail = await service.GetOneUser(authentication.UserName);
            UserDto dto = new UserDto()
            {
                UserId = detail.Id,
                UserName = authentication.UserName,
                UserAccessToken = await service.CreatToken(),
                UserFirstName = detail.UserFirsName,
                UserLastName = detail.UserName


            };
            return Ok(dto);
        }
    }
}
