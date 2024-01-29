using AzureBaseUser.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace AzureBaseUser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserDBContext userDBContext;

        public UserController(UserDBContext _userDBContext)
        {
            this.userDBContext = _userDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {


            return Ok(this.userDBContext.Users.ToList());
        }
        [HttpPost]
        public async Task<ActionResult<User>> Add(User user)
        {



            this.userDBContext.Users.Add(user);
            this.userDBContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult<User>> Delete(User user)
        {



            this.userDBContext.Users.Remove(user);
            this.userDBContext.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<User>> Update(User user)
        {

            this.userDBContext.Users.Update(user);
            this.userDBContext.SaveChanges();
            return Ok();
        }
    }
}
