using Lab.Net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Lab.Net.Data;
using Lab.Net.Service.Account;

namespace Lab.Net.Controllers.User
{
    

    
    [Route("api/account")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IAccountService accountService;
        
        public UserController(IAccountService accountService)
        {
 
            this.accountService = accountService;
        }

       
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Register(UserRegisterModel model)
        {
            return Ok(accountService.Registration(model));
        }

        [HttpPost("login")]
        public IActionResult Login (LoginCredentials credentials)
        {
            return Ok(accountService.Login(credentials));
        }







    }
}
