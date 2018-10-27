using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace webapplication.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet,Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] 
            {
                "User1",
                "User2",
                "User3",
                "User4"
            };
        }

    }
}
