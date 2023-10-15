using Lab.Net.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab.Net.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<UserDto> Users { get; set; } = null!;


    }
}
