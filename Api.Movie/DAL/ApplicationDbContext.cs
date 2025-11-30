using Api.Movie.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Movie.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Sección para crear el dbset de las entidades o modelos
        public DbSet<Category> Categories { get; set; }
    }
}
