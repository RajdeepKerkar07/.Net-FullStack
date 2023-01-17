

using Day4Assignment.Data;
using Microsoft.EntityFrameworkCore;

namespace Day4Assignment.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
    }
}
