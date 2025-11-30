using Api.Movie.DAL;
using Api.Movie.DAL.Models;
using Api.Movie.Repository.IRepository;
using API.Movies.DAL;
using API.Movies.DAL.Models;
using API.Movies.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Movies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> MovieExistsByIdAsync(int id)
        {
            return await _context.Movies
                .AsNoTracking()
                .AnyAsync(c => c.Id == id);
        }

        public async Task<bool> MovieExistsByNameAsync(string name)
        {
            return await _context.Movies
                .AsNoTracking()
                .AnyAsync(c => c.Name == name);
        }

        public async Task<bool> CreateMovieAsync(Movie movie)
        {
            movie.CreatedDate = DateTime.UtcNow;
            await _context.Movies.AddAsync(movie);
            return await SaveAsync();
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await GetMovieAsync(id); //primero consulto que sí exista la pelicula

            if (movie == null)
            {
                return false; //la pelicula no existe
            }

            _context.Movies.Remove(movie);
            return await SaveAsync();
        }

        public async Task<ICollection<Movie>> GetMoviesAsync()
        {
            return await _context.Movies
                .AsNoTracking()
                .OrderBy(c => c.Name)
                .ToListAsync();
        }

        public async Task<Movie> GetMovieAsync(int id) 
        {
            return await _context.Movies
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id); 
        }

        public async Task<bool> UpdateMovieAsync(Movie movie)
        {
            movie.ModifiedDate = DateTime.UtcNow;
            _context.Movies.Update(movie);
            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0 ? true : false;
        }
    }
}