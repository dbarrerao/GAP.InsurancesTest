using GAP.Business.Interfaces;
using GAP.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GAP.InsurancesTest.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        
        // POST api/<controller>
        [HttpPost]
        public bool Post([FromBody] User user)
        {
           return _userBusiness.ValidateUser(user);
        }

    }
}
