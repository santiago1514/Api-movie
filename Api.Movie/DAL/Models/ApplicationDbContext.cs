using Api.Movie.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Movie.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Api.Movies.DAL.Models.Movie> Movies { get; set; }
    }
}
