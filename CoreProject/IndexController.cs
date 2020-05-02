using System.Collections.Generic;
using System.Linq;
using CoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject
{
    public class IndexController : Controller
    {
        // GET
        public IActionResult Index()
        {
            var users = new List<User>();
            using (var context = new UserContext())
            {
                UserContextSeeder.Seed(context);

                users = context.Users.ToList();
            }
            return Json(users);
        }
    }
}