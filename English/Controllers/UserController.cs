using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using English.Services;
using Microsoft.AspNetCore.Mvc;

namespace English.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser iUser;

        public UserController(IUser iUser)
        {
            this.iUser = iUser;
        }

        public IActionResult Index()
        {
            return View(iUser.getUsers);
        }
    }
}