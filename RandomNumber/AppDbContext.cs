using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RandomNumber.Models;

namespace RandomNumber
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<CodeUserGenerate> CodeUserGenerate { get; set; }
    }
}
