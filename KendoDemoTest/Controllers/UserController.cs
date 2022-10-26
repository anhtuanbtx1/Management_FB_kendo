using Core_Db.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KendoDemoTest.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository mUserRepository;
        public UserController(IUserRepository UserRepository)
        {
            mUserRepository = UserRepository;
        }
        public JsonResult GetUser()
        {
            var user = mUserRepository.GetAll().ToList();
            return Json(user);
        }
    }
}
