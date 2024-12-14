using CodeFirst_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CodeFirst_1.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Game> Games { get; set; }

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options)
             : base(options)
        {
        }
    }
}
