
namespace Api.Movie.Repository
{
    public interface IMovieRepository
    {

        Task<ICollection<Api.Movies.DAL.Models.Movie>> GetMoviesAsync();
        Task<Api.Movies.DAL.Models.Movie> GetMovieAsync(int id);         

        
        Task<bool> MovieExistsByIdAsync(int id);
        Task<bool> MovieExistsByNameAsync(string name);

        // Métodos de escritura (Devuelven bool )
        Task<bool> CreateMovieAsync(Api.Movies.DAL.Models.Movie movie);  
        Task<bool> UpdateMovieAsync(Api.Movies.DAL.Models.Movie movie);  
        Task<bool> DeleteMovieAsync(int id);
        
    }
}
