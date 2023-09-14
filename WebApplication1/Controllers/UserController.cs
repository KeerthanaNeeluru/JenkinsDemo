using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Sam",UserPwd="sam@123",UserEmail="sam@gmail.com"},
            new User(){UserId=2,UserName="Amit",UserPwd="amit@123",UserEmail="amit@gmail.com"},
            new User(){UserId=3,UserName="Raj",UserPwd="raj@123",UserEmail="raj@gmail.com"},
            new User(){UserId=4,UserName="James",UserPwd="james@123",UserEmail="james@gmail.com"},
            new User(){UserId=5,UserName="Jhon",UserPwd="jhon@123",UserEmail="jhon@gmail.com"},
          
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if(ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
        }
    }
}
