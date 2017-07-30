using Microsoft.AspNetCore.Mvc;
using ScoreKeepWeb.Models;
using ScoreKeepWeb.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepWeb.Controllers.Api
{
    public class UsersController : Controller
    {
        private IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet("api/users")]
        public IActionResult Get()
        {
            var data = usersRepository.GetAllUsers();
            return Ok(data);
        }
    }
}
