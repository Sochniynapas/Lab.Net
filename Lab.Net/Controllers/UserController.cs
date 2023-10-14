using Lab.Net.Models;
using Microsoft.EntityFrameworkCore;
namespace Lab.Net.Controllers
{
    public class UserController : DbContext
    {
        public DbSet<UserDto> Users => Set<UserDto>();

        public UserController(DbContextOptions<UserController> options)
            :base(options)
        {
            
        }






    }
}
