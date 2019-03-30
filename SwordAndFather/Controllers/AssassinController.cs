using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwordAndFather.Controllers.Modals;

namespace SwordAndFather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssassinController : ControllerBase
    {
        readonly CreateAssassinRequestValidator _validator;
        readonly AssassinRepository _repository;

        public AssassinController()
        {
            _validator = new CreateAssassinRequestValidator();
            _repository = new AssassinRepository();
        }

        [HttpPost("register")]
        public ActionResult AddAssassin(CreateAssassinRequest request)
        {
            if (_validator.Validate(request))
            {
                return BadRequest();
            }

            var newAssassin = _repository.AddAssassin(request.CodeName, request.Catchphrase, request.PrefferedWeapon);

            return Created($"api/assassins/{newAssassin.Id}", newAssassin);
        }
    }
}