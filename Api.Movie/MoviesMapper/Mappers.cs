using Api.Movie.DAL.Models;
using Api.Movie.DAL.Models.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api.Movie.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();

            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieCreateUpdateDto>().ReverseMap();
        }
    }
}
