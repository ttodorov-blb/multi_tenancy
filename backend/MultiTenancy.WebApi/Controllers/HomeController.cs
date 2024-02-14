using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MultiTenancy.WebApi.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return this.Ok("Hello my friend!");
        }
    }
}