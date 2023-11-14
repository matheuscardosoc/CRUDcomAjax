using CRUDcomAjax.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDcomAjax.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
