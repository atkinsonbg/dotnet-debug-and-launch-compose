using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.Data;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly UsersContext _usersContext;

        public UsersController(UsersContext usersContext, ILogger<UsersController> logger)
        {
            _logger = logger;
            _usersContext = usersContext;
        }

        [HttpGet]
        public ActionResult<UsersEntity> Get()
        {
            // Don't do this in real life, use the repository pattern and keep DBContext out of your controllers!!
            return _usersContext.UsersEntity.FirstOrDefault();
        }
    }
}
