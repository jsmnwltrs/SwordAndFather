using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwordAndFather.Controllers.Modals;
using SwordAndFather.Models;

namespace SwordAndFather.Controllers
{
    //Attributes (defines additional info about the class)
    [Route("api/[controller]")]
    [ApiController]

    public class UsersController : ControllerBase
    {
        readonly UserRepository _userRepository;
        readonly CreateUserRequestValidator _validator;

        public UsersController()
        {
            _validator = new CreateUserRequestValidator();
            _userRepository = new UserRepository();
        }

        [HttpPost("register")]
        public ActionResult AddUser(CreateUserRequest createRequest)
        {
            //validation
            if (_validator.Validate(createRequest))
            {
                return BadRequest(new { error = "users must have a username and password" });
            }

            var newUser = _userRepository.AddUser(createRequest.Username, createRequest.Password);

            return Created($"api/users/{newUser.Id}", newUser);
        }
    }
}